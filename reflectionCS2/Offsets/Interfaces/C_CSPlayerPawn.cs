using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionCS2.Offsets.Interfaces
{
    internal class C_CSPlayerPawn : InterfaceBase
    {
        public C_CSPlayerPawn() : base("")
        {

        }

        public  nint m_pBulletServices = 0x1678; // CCSPlayer_BulletServices*
        public  nint m_pHostageServices = 0x1680; // CCSPlayer_HostageServices*
        public  nint m_pBuyServices = 0x1688; // CCSPlayer_BuyServices*
        public  nint m_pGlowServices = 0x1690; // CCSPlayer_GlowServices*
        public  nint m_pActionTrackingServices = 0x1698; // CCSPlayer_ActionTrackingServices*
        public  nint m_pDamageReactServices = 0x16A0; // CCSPlayer_DamageReactServices*
        public  nint m_flHealthShotBoostExpirationTime = 0x16A8; // GameTime_t
        public  nint m_flLastFiredWeaponTime = 0x16AC; // GameTime_t
        public  nint m_bHasFemaleVoice = 0x16B0; // bool
        public  nint m_flLandingTimeSeconds = 0x16B4; // float32
        public  nint m_flOldFallVelocity = 0x16B8; // float32
        public  nint m_szLastPlaceName = 0x16BC; // char[18]
        public  nint m_bPrevDefuser = 0x16CE; // bool
        public  nint m_bPrevHelmet = 0x16CF; // bool
        public  nint m_nPrevArmorVal = 0x16D0; // int32
        public  nint m_nPrevGrenadeAmmoCount = 0x16D4; // int32
        public  nint m_unPreviousWeaponHash = 0x16D8; // uint32
        public  nint m_unWeaponHash = 0x16DC; // uint32
        public  nint m_bInBuyZone = 0x16E0; // bool
        public  nint m_bPreviouslyInBuyZone = 0x16E1; // bool
        public  nint m_aimPunchAngle = 0x16E4; // QAngle
        public  nint m_aimPunchAngleVel = 0x16F0; // QAngle
        public  nint m_aimPunchTickBase = 0x16FC; // GameTick_t
        public  nint m_aimPunchTickFraction = 0x1700; // float32
        public  nint m_aimPunchCache = 0x1708; // CUtlVector<QAngle>
        public  nint m_bInLanding = 0x1728; // bool
        public  nint m_flLandingStartTime = 0x172C; // float32
        public  nint m_bInHostageRescueZone = 0x1730; // bool
        public  nint m_bInBombZone = 0x1731; // bool
        public  nint m_bIsBuyMenuOpen = 0x1732; // bool
        public  nint m_flTimeOfLastInjury = 0x1734; // GameTime_t
        public  nint m_flNextSprayDecalTime = 0x1738; // GameTime_t
        public  nint m_iRetakesOffering = 0x1890; // int32
        public  nint m_iRetakesOfferingCard = 0x1894; // int32
        public  nint m_bRetakesHasDefuseKit = 0x1898; // bool
        public  nint m_bRetakesMVPLastRound = 0x1899; // bool
        public  nint m_iRetakesMVPBoostItem = 0x189C; // int32
        public  nint m_RetakesMVPBoostExtraUtility = 0x18A0; // loadout_slot_t
        public  nint m_bNeedToReApplyGloves = 0x18A5; // bool
        public  nint m_EconGloves = 0x18A8; // C_EconItemView
        public  nint m_nEconGlovesChanged = 0x1D20; // uint8
        public  nint m_bMustSyncRagdollState = 0x1D21; // bool
        public  nint m_nRagdollDamageBone = 0x1D24; // int32
        public  nint m_vRagdollDamageForce = 0x1D28; // Vector
        public  nint m_vRagdollDamagePosition = 0x1D34; // Vector
        public  nint m_szRagdollDamageWeaponName = 0x1D40; // char[64]
        public  nint m_bRagdollDamageHeadshot = 0x1D80; // bool
        public  nint m_vRagdollServerOrigin = 0x1D84; // Vector
        public  nint m_lastLandTime = 0x2400; // GameTime_t
        public  nint m_bOnGroundLastTick = 0x2404; // bool
        public  nint m_hHudModelArms = 0x2420; // CHandle<C_CS2HudModelArms>
        public  nint m_qDeathEyeAngles = 0x2424; // QAngle
        public  nint m_bSkipOneHeadConstraintUpdate = 0x2430; // bool
        public  nint m_bLeftHanded = 0x2431; // bool
        public  nint m_fSwitchedHandednessTime = 0x2434; // GameTime_t
        public  nint m_flViewmodelOffsetX = 0x2438; // float32
        public  nint m_flViewmodelOffsetY = 0x243C; // float32
        public  nint m_flViewmodelOffsetZ = 0x2440; // float32
        public  nint m_flViewmodelFOV = 0x2444; // float32
        public  nint m_vecPlayerPatchEconIndices = 0x2448; // uint32[5]
        public  nint m_GunGameImmunityColor = 0x2480; // Color
        public  nint m_vecBulletHitModels = 0x24D0; // CUtlVector<C_BulletHitModel*>
        public  nint m_bIsWalking = 0x24E8; // bool
        public  nint m_thirdPersonHeading = 0x24F0; // QAngle
        public  nint m_flSlopeDropOffset = 0x2580; // float32
        public  nint m_flSlopeDropHeight = 0x25F8; // float32
        public  nint m_vHeadConstraintOffset = 0x2670; // Vector
        public  nint m_entitySpottedState = 0x2700; // EntitySpottedState_t
        public  nint m_bIsScoped = 0x2718; // bool
        public  nint m_bResumeZoom = 0x2719; // bool
        public  nint m_bIsDefusing = 0x271A; // bool
        public nint m_bIsGrabbingHostage = 0x271B; // bool
        public  nint m_iBlockingUseActionInProgress = 0x271C; // CSPlayerBlockingUseAction_t
        public  nint m_flEmitSoundTime = 0x2720; // GameTime_t
        public  nint m_bInNoDefuseArea = 0x2724; // bool
        public  nint m_nWhichBombZone = 0x2728; // int32
        public  nint m_iShotsFired = 0x272C; // int32
        public  nint m_flFlinchStack = 0x2730; // float32
        public  nint m_flVelocityModifier = 0x2734; // float32
        public  nint m_flHitHeading = 0x2738; // float32
        public  nint m_nHitBodyPart = 0x273C; // int32
        public  nint m_bWaitForNoAttack = 0x2740; // bool
        public  nint m_ignoreLadderJumpTime = 0x2744; // float32
        public  nint m_bKilledByHeadshot = 0x2749; // bool
        public  nint m_ArmorValue = 0x274C; // int32
        public  nint m_unCurrentEquipmentValue = 0x2750; // uint16
        public  nint m_unRoundStartEquipmentValue = 0x2752; // uint16
        public  nint m_unFreezetimeEndEquipmentValue = 0x2754; // uint16
        public  nint m_nLastKillerIndex = 0x2758; // CEntityIndex
        public  nint m_bOldIsScoped = 0x275C; // bool
        public  nint m_bHasDeathInfo = 0x275D; // bool
        public nint m_flDeathInfoTime = 0x2760; // float32
        public nint m_vecDeathInfoOrigin = 0x2764; // Vector
        public nint m_grenadeParameterStashTime = 0x2774; // GameTime_t
        public nint m_bGrenadeParametersStashed = 0x2778; // bool
        public nint m_angStashedShootAngles = 0x277C; // QAngle
        public nint m_vecStashedGrenadeThrowPosition = 0x2788; // Vector
        public nint m_vecStashedVelocity = 0x2794; // Vector
        public nint m_angShootAngleHistory = 0x27A0; // QAngle[2]
        public nint m_vecThrowPositionHistory = 0x27B8; // Vector[2]
        public nint m_vecVelocityHistory = 0x27D0; // Vector[2]
        public nint m_PredictedDamageTags = 0x27E8; // C_UtlVectorEmbeddedNetworkVar<PredictedDamageTag_t>
        public nint m_nPrevHighestReceivedDamageTagTick = 0x2850; // GameTick_t
        public nint m_nHighestAppliedDamageTagTick = 0x2854; // int32
        public nint m_bShouldAutobuyDMWeapons = 0x3D8C; // bool
        public nint m_fImmuneToGunGameDamageTime = 0x3D90; // GameTime_t
        public nint m_bGunGameImmunity = 0x3D94; // bool
        public nint m_fImmuneToGunGameDamageTimeLast = 0x3D98; // GameTime_t
        public nint m_fMolotovDamageTime = 0x3D9C; // float32
        public nint m_vecLastAliveLocalVelocity = 0x3DA4; // Vector
        public nint m_fRenderingClipPlane = 0x3DB0; // float32[4]
        public nint m_nLastClipPlaneSetupFrame = 0x3DC0; // int32
        public nint m_vecLastClipCameraPos = 0x3DC4; // Vector
        public nint m_vecLastClipCameraForward = 0x3DD0; // Vector
        public nint m_bClipHitStaticWorld = 0x3DDC; // bool
        public nint m_bCachedPlaneIsValid = 0x3DDD; // bool
        public nint m_pClippingWeapon = 0x3DE0; // C_CSWeaponBase*
        public nint m_nPlayerInfernoBodyFx = 0x3DE8; // ParticleIndex_t
        public nint m_angEyeAngles = 0x3DF0; // QAngle
        public nint m_arrOldEyeAnglesTimes = 0x3E80; // GameTime_t[4]
        public nint m_arrOldEyeAngles = 0x3E90; // QAngle[4]
        public nint m_angEyeAnglesVelocity = 0x3EC0; // QAngle
        public nint m_iIDEntIndex = 0x3ECC; // CEntityIndex
        public  nint m_delayTargetIDTimer = 0x3ED0; // CountdownTimer
        public  nint m_iTargetItemEntIdx = 0x3EE8; // CEntityIndex
        public  nint m_iOldIDEntIndex = 0x3EEC; // CEntityIndex
        public  nint m_holdTargetIDTimer = 0x3EF0; // CountdownTimer
    }
}
