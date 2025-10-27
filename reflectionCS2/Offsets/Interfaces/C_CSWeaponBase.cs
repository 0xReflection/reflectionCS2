using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionCS2.Offsets.Interfaces
{
    internal class C_CSWeaponBase : InterfaceBase
    {
        public C_CSWeaponBase() : base("")
        {

        }
      
        public  nint m_iWeaponGameplayAnimState = 0x1970; // WeaponGameplayAnimState
        public  nint m_flWeaponGameplayAnimStateTimestamp = 0x1974; // GameTime_t
        public  nint m_flInspectCancelCompleteTime = 0x1978; // GameTime_t
        public  nint m_bInspectPending = 0x197C; // bool
        public  nint m_bInspectShouldLoop = 0x197D; // bool
        public  nint m_flCrosshairDistance = 0x19A8; // float32
        public  nint m_iAmmoLastCheck = 0x19AC; // int32
        public  nint m_nLastEmptySoundCmdNum = 0x19B0; // int32
        public  nint m_bFireOnEmpty = 0x19B4; // bool
        public  nint m_OnPlayerPickup = 0x19B8; // CEntityIOOutput
        public  nint m_weaponMode = 0x19E0; // CSWeaponMode
        public  nint m_flTurningInaccuracyDelta = 0x19E4; // float32
        public  nint m_vecTurningInaccuracyEyeDirLast = 0x19E8; // Vector
        public  nint m_flTurningInaccuracy = 0x19F4; // float32
        public  nint m_fAccuracyPenalty = 0x19F8; // float32
        public  nint m_flLastAccuracyUpdateTime = 0x19FC; // GameTime_t
        public  nint m_fAccuracySmoothedForZoom = 0x1A00; // float32
        public  nint m_iRecoilIndex = 0x1A04; // int32
        public  nint m_flRecoilIndex = 0x1A08; // float32
        public  nint m_bBurstMode = 0x1A0C; // bool
        public  nint m_flLastBurstModeChangeTime = 0x1A10; // GameTime_t
        public  nint m_nPostponeFireReadyTicks = 0x1A14; // GameTick_t
        public  nint m_flPostponeFireReadyFrac = 0x1A18; // float32
        public  nint m_bInReload = 0x1A1C; // bool
        public  nint m_flDroppedAtTime = 0x1A20; // GameTime_t
        public  nint m_bIsHauledBack = 0x1A24; // bool
        public  nint m_bSilencerOn = 0x1A25; // bool
        public  nint m_flTimeSilencerSwitchComplete = 0x1A28; // GameTime_t
        public  nint m_iOriginalTeamNumber = 0x1A2C; // int32
        public  nint m_iMostRecentTeamNumber = 0x1A30; // int32
        public  nint m_bDroppedNearBuyZone = 0x1A34; // bool
        public  nint m_flNextAttackRenderTimeOffset = 0x1A38; // float32
        public  nint m_bClearWeaponIdentifyingUGC = 0x1AD8; // bool
        public nint m_bVisualsDataSet = 0x1AD9; // bool
        public nint m_bUIWeapon = 0x1ADA; // bool
        public nint m_nCustomEconReloadEventId = 0x1ADC; // int32
        public nint m_nextPrevOwnerUseTime = 0x1AE8; // GameTime_t
        public nint m_hPrevOwner = 0x1AEC; // CHandle<C_CSPlayerPawn>
        public nint m_nDropTick = 0x1AF0; // GameTick_t
        public nint m_bWasActiveWeaponWhenDropped = 0x1AF4; // bool
        public nint m_donated = 0x1B14; // bool
        public nint m_fLastShotTime = 0x1B18; // GameTime_t
        public nint m_bWasOwnedByCT = 0x1B1C; // bool
        public nint m_bWasOwnedByTerrorist = 0x1B1D; // bool
        public nint m_flNextClientFireBulletTime = 0x1B20; // float32
        public nint m_flNextClientFireBulletTime_Repredict = 0x1B24; // float32
        public nint m_IronSightController = 0x1C90; // C_IronSightController
        public nint m_iIronSightMode = 0x1D40; // int32
        public nint m_flLastLOSTraceFailureTime = 0x1D58; // GameTime_t
        public nint m_flWatTickOffset = 0x1DB8; // float32
        public nint m_flLastShakeTime = 0x1DCC; // GameTime_t

    }
}
