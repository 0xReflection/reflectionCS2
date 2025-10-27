using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionCS2.Offsets.Interfaces
{
    internal class CCSPlayerController : InterfaceBase
    {
        public CCSPlayerController() : base("")
        {
        }

        public  nint m_pInGameMoneyServices = 0x7F8; // CCSPlayerController_InGameMoneyServices*
        public  nint m_pInventoryServices = 0x800; // CCSPlayerController_InventoryServices*
        public nint m_pActionTrackingServices = 0x808; // CCSPlayerController_ActionTrackingServices*
        public nint m_pDamageServices = 0x810; // CCSPlayerController_DamageServices*
        public nint m_iPing = 0x818; // uint32
        public nint m_bHasCommunicationAbuseMute = 0x81C; // bool
        public nint m_uiCommunicationMuteFlags = 0x820; // uint32
        public nint m_szCrosshairCodes = 0x828; // CUtlSymbolLarge
        public nint m_iPendingTeamNum = 0x830; // uint8
        public nint m_flForceTeamTime = 0x834; // GameTime_t
        public nint m_iCompTeammateColor = 0x838; // int32
        public nint m_bEverPlayedOnTeam = 0x83C; // bool
        public nint m_flPreviousForceJoinTeamTime = 0x840; // GameTime_t
        public nint m_szClan = 0x848; // CUtlSymbolLarge
        public nint m_sSanitizedPlayerName = 0x850; // CUtlString
        public nint m_iCoachingTeam = 0x858; // int32
        public nint m_nPlayerDominated = 0x860; // uint64
        public nint m_nPlayerDominatingMe = 0x868; // uint64
        public nint m_iCompetitiveRanking = 0x870; // int32
        public nint m_iCompetitiveWins = 0x874; // int32
        public nint m_iCompetitiveRankType = 0x878; // int8
        public nint m_iCompetitiveRankingPredicted_Win = 0x87C; // int32
        public nint m_iCompetitiveRankingPredicted_Loss = 0x880; // int32
        public nint m_iCompetitiveRankingPredicted_Tie = 0x884; // int32
        public nint m_nEndMatchNextMapVote = 0x888; // int32
        public nint m_unActiveQuestId = 0x88C; // uint16
        public nint m_rtActiveMissionPeriod = 0x890; // uint32
        public nint m_nQuestProgressReason = 0x894; // QuestProgress::Reason
        public nint m_unPlayerTvControlFlags = 0x898; // uint32
        public nint m_iDraftIndex = 0x8C8; // int32
        public nint m_msQueuedModeDisconnectionTimestamp = 0x8CC; // uint32
        public nint m_uiAbandonRecordedReason = 0x8D0; // uint32
        public nint m_eNetworkDisconnectionReason = 0x8D4; // uint32
        public nint m_bCannotBeKicked = 0x8D8; // bool
        public nint m_bEverFullyConnected = 0x8D9; // bool
        public nint m_bAbandonAllowsSurrender = 0x8DA; // bool
        public nint m_bAbandonOffersInstantSurrender = 0x8DB; // bool
        public nint m_bDisconnection1MinWarningPrinted = 0x8DC; // bool
        public nint m_bScoreReported = 0x8DD; // bool
        public nint m_nDisconnectionTick = 0x8E0; // int32
        public nint m_bControllingBot = 0x8F0; // bool
        public nint m_bHasControlledBotThisRound = 0x8F1; // bool
        public nint m_bHasBeenControlledByPlayerThisRound = 0x8F2; // bool
        public nint m_nBotsControlledThisRound = 0x8F4; // int32
        public nint m_bCanControlObservedBot = 0x8F8; // bool
        public nint m_hPlayerPawn = 0x8FC; // CHandle<C_CSPlayerPawn>
        public nint m_hObserverPawn = 0x900; // CHandle<C_CSObserverPawn>
        public nint m_bPawnIsAlive = 0x904; // bool
        public nint m_iPawnHealth = 0x908; // uint32
        public nint m_iPawnArmor = 0x90C; // int32
        public nint m_bPawnHasDefuser = 0x910; // bool
        public nint m_bPawnHasHelmet = 0x911; // bool
        public nint m_nPawnCharacterDefIndex = 0x912; // uint16
        public nint m_iPawnLifetimeStart = 0x914; // int32
        public nint m_iPawnLifetimeEnd = 0x918; // int32
        public nint m_iPawnBotDifficulty = 0x91C; // int32
        public nint m_hOriginalControllerOfCurrentPawn = 0x920; // CHandle<CCSPlayerController>
        public nint m_iScore = 0x924; // int32
        public nint m_recentKillQueue = 0x928; // uint8[8]
        public nint m_nFirstKill = 0x930; // uint8
        public nint m_nKillCount = 0x931; // uint8
        public nint m_bMvpNoMusic = 0x932; // bool
        public nint m_eMvpReason = 0x934; // int32
        public nint m_iMusicKitID = 0x938; // int32
        public nint m_iMusicKitMVPs = 0x93C; // int32
        public nint m_iMVPs = 0x940; // int32
        public nint m_bIsPlayerNameDirty = 0x944; // bool
        public nint m_bFireBulletsSeedSynchronized = 0x945; // bool

    }
}
