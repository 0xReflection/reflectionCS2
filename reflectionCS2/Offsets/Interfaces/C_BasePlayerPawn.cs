using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionCS2.Offsets.Interfaces
{
    internal class C_BasePlayerPawn : InterfaceBase
    {
        public C_BasePlayerPawn() : base("")
        {
        }

        public  nint m_pWeaponServices = 0x13F0; // CPlayer_WeaponServices*
        public  nint m_pItemServices = 0x13F8; // CPlayer_ItemServices*
        public  nint m_pAutoaimServices = 0x1400; // CPlayer_AutoaimServices*
        public  nint m_pObserverServices = 0x1408; // CPlayer_ObserverServices*
        public  nint m_pWaterServices = 0x1410; // CPlayer_WaterServices*
        public  nint m_pUseServices = 0x1418; // CPlayer_UseServices*
        public  nint m_pFlashlightServices = 0x1420; // CPlayer_FlashlightServices*
        public  nint m_pCameraServices = 0x1428; // CPlayer_CameraServices*
        public  nint m_pMovementServices = 0x1430; // CPlayer_MovementServices*
        public  nint m_ServerViewAngleChanges = 0x1440; // C_UtlVectorEmbeddedNetworkVar<ViewAngleServerChange_t>
        public  nint v_angle = 0x14A8; // QAngle
        public  nint v_anglePrevious = 0x14B4; // QAngle
        public  nint m_iHideHUD = 0x14C0; // uint32
        public  nint m_skybox3d = 0x14C8; // sky3dparams_t
        public  nint m_flDeathTime = 0x1558; // GameTime_t
        public  nint m_vecPredictionError = 0x155C; // Vector
        public  nint m_flPredictionErrorTime = 0x1568; // GameTime_t
        public  nint m_vecLastCameraSetupLocalOrigin = 0x1588; // Vector
        public  nint m_flLastCameraSetupTime = 0x1594; // GameTime_t
        public  nint m_flFOVSensitivityAdjust = 0x1598; // float32
        public nint m_flMouseSensitivity = 0x159C; // float32
        public nint m_vOldOrigin = 0x15A0; // Vector
        public nint m_flOldSimulationTime = 0x15AC; // float32
        public nint m_nLastExecutedCommandNumber = 0x15B0; // int32
        public nint m_nLastExecutedCommandTick = 0x15B4; // int32
        public nint m_hController = 0x15B8; // CHandle<CBasePlayerController>
        public nint m_hDefaultController = 0x15BC; // CHandle<CBasePlayerController>
        public  nint m_bIsSwappingToPredictableController = 0x15C0; // bool

    }
}
