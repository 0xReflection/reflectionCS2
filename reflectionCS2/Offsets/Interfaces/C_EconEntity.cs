using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionCS2.Offsets.Interfaces
{
    internal class C_EconEntity : InterfaceBase
    {
        public C_EconEntity() : base("")
        {

        }

        public  nint m_flFlexDelayTime = 0x1378; // float32
        public  nint m_flFlexDelayedWeight = 0x1380; // float32*
        public  nint m_bAttributesInitialized = 0x1388; // bool
        public  nint m_AttributeManager = 0x1390; // C_AttributeContainer
        public  nint m_OriginalOwnerXuidLow = 0x1868; // uint32
        public  nint m_OriginalOwnerXuidHigh = 0x186C; // uint32
        public  nint m_nFallbackPaintKit = 0x1870; // int32
        public  nint m_nFallbackSeed = 0x1874; // int32
        public  nint m_flFallbackWear = 0x1878; // float32
        public  nint m_nFallbackStatTrak = 0x187C; // int32
        public  nint m_bClientside = 0x1880; // bool
        public  nint m_bParticleSystemsCreated = 0x1881; // bool
        public  nint m_vecAttachedParticles = 0x1888; // CUtlVector<int32>
        public  nint m_hViewmodelAttachment = 0x18A0; // CHandle<CBaseAnimGraph>
        public  nint m_iOldTeam = 0x18A4; // int32
        public  nint m_bAttachmentDirty = 0x18A8; // bool
        public  nint m_nUnloadedModelIndex = 0x18AC; // int32
        public  nint m_iNumOwnerValidationRetries = 0x18B0; // int32
        public  nint m_hOldProvidee = 0x18C0; // CHandle<C_BaseEntity>
        public  nint m_vecAttachedModels = 0x18C8; // CUtlVector<C_EconEntity::AttachedModelData_t>

    }
}
