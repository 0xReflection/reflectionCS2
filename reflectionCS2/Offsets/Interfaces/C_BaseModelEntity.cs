using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionCS2.Offsets.Interfaces
{
    internal class C_BaseModelEntity : InterfaceBase
    {
        public C_BaseModelEntity() : base("")
        {

        }

        public IntPtr m_CHitboxComponent = 0xAE8; // CHitboxComponent
        public IntPtr m_vecViewOffset = 0xD80; // CNetworkViewOffsetVector
    }
}
