using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionCS2.Offsets.Interfaces
{
    internal class C_EconItemView : InterfaceBase
    {
        public C_EconItemView() : base("")
        {

        }

        public  nint m_bInventoryImageRgbaRequested = 0x60; // bool
        public  nint m_bInventoryImageTriedCache = 0x61; // bool
        public  nint m_nInventoryImageRgbaWidth = 0x80; // int32
        public  nint m_nInventoryImageRgbaHeight = 0x84; // int32
        public  nint m_szCurrentLoadCachedFileName = 0x88; // char[260]
        public  nint m_bRestoreCustomMaterialAfterPrecache = 0x1B8; // bool
        public  nint m_iItemDefinitionIndex = 0x1BA; // uint16
        public  nint m_iEntityQuality = 0x1BC; // int32
        public  nint m_iEntityLevel = 0x1C0; // uint32
        public  nint m_iItemID = 0x1C8; // uint64
        public  nint m_iItemIDHigh = 0x1D0; // uint32
        public  nint m_iItemIDLow = 0x1D4; // uint32
        public  nint m_iAccountID = 0x1D8; // uint32
        public  nint m_iInventoryPosition = 0x1DC; // uint32
        public  nint m_bInitialized = 0x1E8; // bool
        public  nint m_bDisallowSOC = 0x1E9; // bool
        public  nint m_bIsStoreItem = 0x1EA; // bool
        public  nint m_bIsTradeItem = 0x1EB; // bool
        public  nint m_iEntityQuantity = 0x1EC; // int32
        public  nint m_iRarityOverride = 0x1F0; // int32
        public  nint m_iQualityOverride = 0x1F4; // int32
        public  nint m_iOriginOverride = 0x1F8; // int32
        public  nint m_ubStyleOverride = 0x1FC; // uint8
        public  nint m_unClientFlags = 0x1FD; // uint8
        public  nint m_AttributeList = 0x210; // CAttributeList
        public  nint m_NetworkedDynamicAttributes = 0x288; // CAttributeList
        public  nint m_szCustomName = 0x300; // char[161]
        public  nint m_szCustomNameOverride = 0x3A1; // char[161]
        public  nint m_bInitializedTags = 0x470; // bool

    }
}
