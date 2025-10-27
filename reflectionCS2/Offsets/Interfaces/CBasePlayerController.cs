using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionCS2.Offsets.Interfaces
{
    internal class CBasePlayerController : InterfaceBase
    {
        public CBasePlayerController() : base("")
        {
        }

        public  nint m_CommandContext = 0x600; // C_CommandContext
        public nint m_nInButtonsWhichAreToggles = 0x6A8; // uint64
        public nint m_nTickBase = 0x6B0; // uint32
        public nint m_hPawn = 0x6B4; // CHandle<C_BasePlayerPawn>
        public nint m_bKnownTeamMismatch = 0x6B8; // bool
        public nint m_hPredictedPawn = 0x6BC; // CHandle<C_BasePlayerPawn>
        public nint m_nSplitScreenSlot = 0x6C0; // CSplitScreenSlot
        public nint m_hSplitOwner = 0x6C4; // CHandle<CBasePlayerController>
        public nint m_hSplitScreenPlayers = 0x6C8; // CUtlVector<CHandle<CBasePlayerController>>
        public nint m_bIsHLTV = 0x6E0; // bool
        public nint m_iConnected = 0x6E4; // PlayerConnectedState
        public nint m_iszPlayerName = 0x6E8; // char[128]
        public nint m_steamID = 0x770; // uint64
        public nint m_bIsLocalPlayerController = 0x778; // bool
        public nint m_bNoClipEnabled = 0x779; // bool
        public nint m_iDesiredFOV = 0x77C; // uint32

    }
}
