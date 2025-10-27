using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionCS2.Offsets.Interfaces
{
    internal class CGameSceneNode : InterfaceBase
    {
        public CGameSceneNode() : base("")
        {
        }

        public nint m_nodeToWorld = 0x10; // CTransformWS
        public nint m_pOwner = 0x30; // CEntityInstance*
        public nint m_pParent = 0x38; // CGameSceneNode*
        public nint m_pChild = 0x40; // CGameSceneNode*
        public nint m_pNextSibling = 0x48; // CGameSceneNode*
        public nint m_hParent = 0x78; // CGameSceneNodeHandle
        public nint m_vecOrigin = 0x88; // CNetworkOriginCellCoordQuantizedVector
        public nint m_angRotation = 0xC0; // QAngle
        public nint m_flScale = 0xCC; // float32
        public nint m_vecAbsOrigin = 0xD0; // VectorWS
        public nint m_angAbsRotation = 0xDC; // QAngle
        public nint m_flAbsScale = 0xE8; // float32
        public   nint m_vecWrappedLocalOrigin = 0xEC; // Vector
        public nint m_angWrappedLocalRotation = 0xF8; // QAngle
        public nint m_flWrappedScale = 0x104; // float32
        public nint m_nParentAttachmentOrBone = 0x108; // int16
        public nint m_bDebugAbsOriginChanges = 0x10A; // bool
        public nint m_bDormant = 0x10B; // bool
        public nint m_bForceParentToBeNetworked = 0x10C; // bool
        public nint m_bDirtyHierarchy = 0x0; // bitfield:1
        public nint m_bDirtyBoneMergeInfo = 0x0; // bitfield:1
        public nint m_bNetworkedPositionChanged = 0x0; // bitfield:1
        public  nint m_bNetworkedAnglesChanged = 0x0; // bitfield:1
        public  nint m_bNetworkedScaleChanged = 0x0; // bitfield:1
        public  nint m_bWillBeCallingPostDataUpdate = 0x0; // bitfield:1
        public  nint m_bBoneMergeFlex = 0x0; // bitfield:1
        public  nint m_nLatchAbsOrigin = 0x0; // bitfield:2
        public nint m_bDirtyBoneMergeBoneToRoot = 0x0; // bitfield:1
        public nint m_nHierarchicalDepth = 0x10F; // uint8
        public nint m_nHierarchyType = 0x110; // uint8
        public nint m_nDoNotSetAnimTimeInInvalidatePhysicsCount = 0x111; // uint8
        public nint m_name = 0x114; // CUtlStringToken
        public nint m_hierarchyAttachName = 0x158; // CUtlStringToken
        public nint m_flZOffset = 0x15C; // float32
        public nint m_flClientLocalScale = 0x160; // float32
        public nint m_vRenderOrigin = 0x164; // Vector


    }
}
