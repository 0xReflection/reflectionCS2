using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionCS2.Offsets.Interfaces
{
    internal class C_CSPlayerPawnBase : InterfaceBase
    {
        public C_CSPlayerPawnBase() : base("")
        {
        }

        public   nint m_pPingServices = 0x15D8; // CCSPlayer_PingServices*
        public nint m_previousPlayerState = 0x15E0; // CSPlayerState
        public nint m_iPlayerState = 0x15E4; // CSPlayerState
        public nint m_bHasMovedSinceSpawn = 0x15E8; // bool
        public nint m_flLastSpawnTimeIndex = 0x15EC; // GameTime_t
        public nint m_iProgressBarDuration = 0x15F0; // int32
        public nint m_flProgressBarStartTime = 0x15F4; // float32
        public nint m_flClientDeathTime = 0x15F8; // GameTime_t
        public nint m_flFlashBangTime = 0x15FC; // float32
        public nint m_flFlashScreenshotAlpha = 0x1600; // float32
        public nint m_flFlashOverlayAlpha = 0x1604; // float32
        public nint m_bFlashBuildUp = 0x1608; // bool
        public nint m_bFlashDspHasBeenCleared = 0x1609; // bool
        public nint m_bFlashScreenshotHasBeenGrabbed = 0x160A; // bool
        public nint m_flFlashMaxAlpha = 0x160C; // float32
        public nint m_flFlashDuration = 0x1610; // float32
        public nint m_flClientHealthFadeChangeTimestamp = 0x1614; // GameTime_t
        public nint m_nClientHealthFadeParityValue = 0x1618; // int32
        public nint m_fNextThinkPushAway = 0x161C; // float32
        public nint m_flCurrentMusicStartTime = 0x1624; // float32
        public nint m_flMusicRoundStartTime = 0x1628; // float32
        public nint m_bDeferStartMusicOnWarmup = 0x162C; // bool
        public nint m_flLastSmokeOverlayAlpha = 0x1630; // float32
        public nint m_flLastSmokeAge = 0x1634; // float32
        public nint m_vLastSmokeOverlayColor = 0x1638; // Vector
        public nint m_hOriginalController = 0x1660; // CHandle<CCSPlayerController>
        public nint m_iIDEntIndex = 0x3ECC; // CEntityIndex
        public nint m_pClippingWeapon = 0x3DE0; // C_CSWeaponBase*
    }
}
