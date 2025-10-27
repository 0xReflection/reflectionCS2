using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionCS2.Offsets.Interfaces
{
    internal class C_BaseEntity : InterfaceBase
    {
        public C_BaseEntity() : base("")
        {

        }

        public  nint m_CBodyComponent = 0x38; // CBodyComponent*
        public  nint m_NetworkTransmitComponent = 0x40; // CNetworkTransmitComponent
        public  nint m_nLastThinkTick = 0x328; // GameTick_t
        public  nint m_pGameSceneNode = 0x330; // CGameSceneNode*
        public  nint m_pRenderComponent = 0x338; // CRenderComponent*
        public  nint m_pCollision = 0x340; // CCollisionProperty*
        public  nint m_iMaxHealth = 0x348; // int32
        public  nint m_iHealth = 0x34C; // int32
        public  nint m_flDamageAccumulator = 0x350; // float32
        public  nint m_lifeState = 0x354; // uint8
        public  nint m_bTakesDamage = 0x355; // bool
        public  nint m_nTakeDamageFlags = 0x358; // TakeDamageFlags_t
        public  nint m_nPlatformType = 0x360; // EntityPlatformTypes_t
        public  nint m_ubInterpolationFrame = 0x361; // uint8
        public  nint m_hSceneObjectController = 0x364; // CHandle<C_BaseEntity>
        public  nint m_nNoInterpolationTick = 0x368; // int32
        public  nint m_nVisibilityNoInterpolationTick = 0x36C; // int32
        public  nint m_flProxyRandomValue = 0x370; // float32
        public  nint m_iEFlags = 0x374; // int32
        public  nint m_nWaterType = 0x378; // uint8
        public  nint m_bInterpolateEvenWithNoModel = 0x379; // bool
        public  nint m_bPredictionEligible = 0x37A; // bool
        public  nint m_bApplyLayerMatchIDToModel = 0x37B; // bool
        public  nint m_tokLayerMatchID = 0x37C; // CUtlStringToken
        public  nint m_nSubclassID = 0x380; // CUtlStringToken
        public  nint m_nSimulationTick = 0x390; // int32
        public  nint m_iCurrentThinkContext = 0x394; // int32
        public  nint m_aThinkFunctions = 0x398; // CUtlVector<thinkfunc_t>
        public  nint m_bDisabledContextThinks = 0x3B0; // bool
        public  nint m_flAnimTime = 0x3B4; // float32
        public  nint m_flSimulationTime = 0x3B8; // float32
        public  nint m_nSceneObjectOverrideFlags = 0x3BC; // uint8
        public  nint m_bHasSuccessfullyInterpolated = 0x3BD; // bool
        public  nint m_bHasAddedVarsToInterpolation = 0x3BE; // bool
        public  nint m_bRenderEvenWhenNotSuccessfullyInterpolated = 0x3BF; // bool
        public  nint m_nInterpolationLatchDirtyFlags = 0x3C0; // int32[2]
        public  nint m_ListEntry = 0x3C8; // uint16[11]
        public  nint m_flCreateTime = 0x3E0; // GameTime_t
        public  nint m_flSpeed = 0x3E4; // float32
        public  nint m_EntClientFlags = 0x3E8; // uint16
        public  nint m_bClientSideRagdoll = 0x3EA; // bool
        public  nint m_iTeamNum = 0x3EB; // uint8
        public  nint m_spawnflags = 0x3EC; // uint32
        public  nint m_nNextThinkTick = 0x3F0; // GameTick_t
        public  nint m_fFlags = 0x3F8; // uint32
        public  nint m_vecAbsVelocity = 0x3FC; // Vector
        public  nint m_vecServerVelocity = 0x408; // CNetworkVelocityVector
        public  nint m_vecVelocity = 0x430; // CNetworkVelocityVector
        public  nint m_vecBaseVelocity = 0x510; // Vector
        public  nint m_hEffectEntity = 0x51C; // CHandle<C_BaseEntity>
        public  nint m_hOwnerEntity = 0x520; // CHandle<C_BaseEntity>
        public  nint m_MoveCollide = 0x524; // MoveCollide_t
        public  nint m_MoveType = 0x525; // MoveType_t
        public  nint m_nActualMoveType = 0x526; // MoveType_t
        public  nint m_flWaterLevel = 0x528; // float32
        public  nint m_fEffects = 0x52C; // uint32
        public  nint m_hGroundEntity = 0x530; // CHandle<C_BaseEntity>
        public  nint m_nGroundBodyIndex = 0x534; // int32
        public  nint m_flFriction = 0x538; // float32
        public  nint m_flElasticity = 0x53C; // float32
        public  nint m_flGravityScale = 0x540; // float32
        public  nint m_flTimeScale = 0x544; // float32
        public  nint m_bAnimatedEveryTick = 0x548; // bool
        public  nint m_bGravityDisabled = 0x549; // bool
        public  nint m_flNavIgnoreUntilTime = 0x54C; // GameTime_t
        public  nint m_hThink = 0x550; // uint16
        public  nint m_fBBoxVisFlags = 0x560; // uint8
        public  nint m_flActualGravityScale = 0x564; // float32
        public  nint m_bGravityActuallyDisabled = 0x568; // bool
        public  nint m_bPredictable = 0x569; // bool
        public  nint m_bRenderWithViewModels = 0x56A; // bool
        public  nint m_nFirstPredictableCommand = 0x56C; // int32
        public  nint m_nLastPredictableCommand = 0x570; // int32
        public  nint m_hOldMoveParent = 0x574; // CHandle<C_BaseEntity>
        public  nint m_Particles = 0x578; // CParticleProperty
        public  nint m_vecAngVelocity = 0x5A8; // QAngle
        public  nint m_DataChangeEventRef = 0x5B4; // int32
        public  nint m_dependencies = 0x5B8; // CUtlVector<CEntityHandle>
        public  nint m_nCreationTick = 0x5D0; // int32
        public  nint m_bAnimTimeChanged = 0x5DD; // bool
        public  nint m_bSimulationTimeChanged = 0x5DE; // bool
        public  nint m_sUniqueHammerID = 0x5E8; // CUtlString
        public  nint m_nBloodType = 0x5F0; // BloodType

    }
}
