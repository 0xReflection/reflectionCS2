using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionCS2.Offsets.Interfaces
{
    internal class C_PlantedC4 : InterfaceBase
    {
        public C_PlantedC4() : base("")
        {

        }

        public  nint m_bBombTicking = 0x1160; // bool

        public nint m_nBombSite = 0x1164; // int32
        public  nint m_nSourceSoundscapeHash = 0x1168; // int32
        public  nint m_entitySpottedState = 0x1170; // EntitySpottedState_t
        public  nint m_flNextGlow = 0x1188; // GameTime_t
        public  nint m_flNextBeep = 0x118C; // GameTime_t
        public  nint m_flC4Blow = 0x1190; // GameTime_t
        public  nint m_bCannotBeDefused = 0x1194; // bool
        public  nint m_bHasExploded = 0x1195; // bool
        public  nint m_flTimerLength = 0x1198; // float32
        public  nint m_bBeingDefused = 0x119C; // bool
        public  nint m_bTriggerWarning = 0x11A0; // float32
        public  nint m_bExplodeWarning = 0x11A4; // float32
        public  nint m_bC4Activated = 0x11A8; // bool
        public  nint m_bTenSecWarning = 0x11A9; // bool
        public  nint m_flDefuseLength = 0x11AC; // float32
        public  nint m_flDefuseCountDown = 0x11B0; // GameTime_t
        public  nint m_bBombDefused = 0x11B4; // bool
        public  nint m_hBombDefuser = 0x11B8; // CHandle<C_CSPlayerPawn>
        public  nint m_AttributeManager = 0x11C0; // C_AttributeContainer
        public  nint m_hDefuserMultimeter = 0x1698; // CHandle<C_Multimeter>
        public  nint m_flNextRadarFlashTime = 0x169C; // GameTime_t
        public  nint m_bRadarFlash = 0x16A0; // bool
        public  nint m_pBombDefuser = 0x16A4; // CHandle<C_CSPlayerPawn>
        public  nint m_fLastDefuseTime = 0x16A8; // GameTime_t
        public  nint m_pPredictionOwner = 0x16B0; // CBasePlayerController*
        public  nint m_vecC4ExplodeSpectatePos = 0x16B8; // Vector
        public  nint m_vecC4ExplodeSpectateAng = 0x16C4; // QAngle
        public  nint m_flC4ExplodeSpectateDuration = 0x16D0; // float32
    }
}
