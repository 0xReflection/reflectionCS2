using reflectionCS2.Config;
using reflectionCS2.game.Features;
using reflectionCS2.game.Structs;
using reflectionCS2.GameOverlay;
using reflectionCS2.Offsets;
using GameOverlay.Drawing;
using SharpDX.DXGI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static reflectionCS2.Offsets.OffsetsLoader;

namespace reflectionCS2.game.Objects
{
    internal class Entity : EntityBase
    {
        public Entity()
        {
            Weapon = new Weapon();
        }

        public Entity(int index, bool bonesOnly = false)
        {
            Index = index;
            BonesOnly = bonesOnly;

            TeamColor = Brushes.Red;
            Weapon = new Weapon();
        }

        public override nint ReadControllerBase()
        {
            var listEntryFirst = Memory.Read<nint>(EntityList + (8 * (Index & 0x7FFF) >> 9) + 0x10);
            return listEntryFirst == nint.Zero
                ? nint.Zero
                : Memory.Read<nint>(listEntryFirst + 120 * (Index & 0x1FF));
        }

        public override nint ReadAddressBase()
        {
            PlayerPawn = Memory.Read<int>(ControllerBase + CBasePlayerController.m_hPawn);
            var listEntrySecond = Memory.Read<nint>(EntityList + 0x8 * ((PlayerPawn & 0x7FFF) >> 9) + 0x10);
            return listEntrySecond == nint.Zero
                ? nint.Zero
                : Memory.Read<nint>(listEntrySecond + 120 * (PlayerPawn & 0x1FF));
        }

        public override bool Update()
        {
            if (!base.Update()) return false;
            if (LocalPlayer.Current.AddressBase == AddressBase)
            {
                LocalPlayer.index = Index;
                return true;
            }

            UpdateBones();

            Dormant = Memory.Read<bool>(AddressBase + CGameSceneNode.m_bDormant);

            if (BonesOnly)
                return true;

            Nickname = Memory.ReadString(ControllerBase + CBasePlayerController.m_iszPlayerName);
            WeaponPtr = Memory.Read<nint>(AddressBase + C_CSPlayerPawnBase.m_pClippingWeapon);
            Weapon.Update(WeaponPtr);

            UpdateSpotted();

            //IsScoped = Memory.Read<bool>(AddressBase + C_CSPlayerPawnBase.m_bIsScoped) && Weapon.IsSniperRifle;
            //IsDefusing = Memory.Read<bool>(AddressBase + C_CSPlayerPawnBase.m_bIsDefusing);
            TeamColor = ToTeamColor(Memory.Read<int>(ControllerBase + CCSPlayerController.m_iCompTeammateColor));

            float flashDuration = Memory.Read<float>(AddressBase + C_CSPlayerPawnBase.m_flFlashDuration);
            float flashBangTime = Memory.Read<float>(AddressBase + C_CSPlayerPawnBase.m_flFlashBangTime);


            FlashDuration = flashDuration;
            FlashTimer =  flashBangTime - GlobalVars.CurrentTime - 0.8f;

            if (FlashTimer < 0)
                FlashTimer = 0;
            if (FlashTimer > 5)
                FlashTimer = 5;

            return true;
        }

        public void UpdateAimProperties()
        {
            Velocity = Memory.Read<Vector3>(AddressBase + C_BaseEntity.m_vecVelocity);
        }

        private void UpdateBones()
        {
            if (!CheckTeam())
                return;
            nint gameSceneNode = Memory.Read<nint>(AddressBase + C_BaseEntity.m_pGameSceneNode);
            nint boneArray = Memory.Read<nint>(gameSceneNode + CSkeletonInstance.m_modelState + 0x80); // CSkeletonInstance -> m_modelState , 128

            var bone = Bones[0];
            nint boneAddress = boneArray + bone.id * 32;
            Vector3 bonePos = Memory.Read<Vector3>(boneAddress);
            HeadPos = bonePos;

            for (int i = 0; i < Bones.Count; i++)
            {
                bone = Bones[i];
                boneAddress = boneArray + bone.id * 32;
                bonePos = Memory.Read<Vector3>(boneAddress);
                Bones[i] = new(bone.bone, bonePos, bone.id);
                if (i == 0)
                    HeadPos = bonePos;
            }
        }

        public void UpdateSpotted()
        {
            ulong spottedMask = Memory.Read<ulong>(AddressBase + C_CSPlayerPawn.m_entitySpottedState + 0xC);
            var s = spottedMask & (ulong)1 << LocalPlayer.index - 1;
            IsSpotted = s != 0;
        }

        public override bool IsAlive()
        {
            return base.IsAlive() && !Dormant && LocalPlayer.Current.AddressBase != AddressBase;
        }

        public bool CheckTeam()
        {
            if (Team == Team.CounterTerrorist || Team == Team.Terrorist)
            {
                return Configuration.Current.DM_Mode_Enabled ? true : Team != LocalPlayer.Current.Team;
            }
            return false;
        }

        private IBrush ToTeamColor(int color)
        {
            if (color == 0)
                return Brushes.TeamBlue;
            else if (color == 1)
                return Brushes.Green;
            else if (color == 2)
                return Brushes.TeamYellow;
            else if (color == 3)
                return Brushes.TeamOrange;
            else if (color == 4)
                return Brushes.TeamPurple;
            return Brushes.Red;
        }

        public Vector3 Velocity { get; private set; }

        public IBrush TeamColor { get; private set; }
        public Weapon Weapon { get; set; }
        private nint WeaponPtr { get; set; }
        public Vector3 HeadPos { get; set; } = Vector3.Zero;
        public List<(Bone bone, Vector3 pos, int id)> Bones
        {
            get; set;
        } = new List<(Bone bone, Vector3 pos, int id)>()
            {
                (Bone.head, Vector3.Zero, 6),           // 0
                (Bone.neck_0, Vector3.Zero, 5),         // 1
                (Bone.spine_1, Vector3.Zero, 4),        // 2
                (Bone.spine_2, Vector3.Zero, 2),        // 3
                (Bone.pelvis, Vector3.Zero, 0),         // 4
                (Bone.arm_upper_L, Vector3.Zero, 8),    // 5
                (Bone.arm_lower_L, Vector3.Zero, 9),    // 6
                (Bone.hand_L, Vector3.Zero, 10),        // 7
                (Bone.arm_upper_R, Vector3.Zero, 13),   // 8
                (Bone.arm_lower_R, Vector3.Zero, 14),   // 9
                (Bone.hand_R, Vector3.Zero, 15),        // 10
                (Bone.leg_upper_L, Vector3.Zero, 22),   // 11
                (Bone.leg_lower_L, Vector3.Zero, 23),   // 12
                (Bone.ankle_L, Vector3.Zero, 24),       // 13
                (Bone.leg_upper_R, Vector3.Zero, 25),   // 14
                (Bone.leg_lower_R, Vector3.Zero, 26),   // 15
                (Bone.ankle_R, Vector3.Zero, 27)        // 16
            };
        public int PlayerPawn { get; set; }
        public int Index { get; private set; }
        public string Nickname { get; private set; }
        public bool IsSpotted { get; private set; }
        public bool IsDefusing { get; set; }
        public float FlashDuration { get; set; }
        public bool IsScoped { get; set; }
        public float FlashTimer { get; set; }

        private bool Dormant { get; set; }
        private bool BonesOnly { get; set; }

    }
}
