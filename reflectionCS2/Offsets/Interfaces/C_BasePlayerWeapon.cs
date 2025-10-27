using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionCS2.Offsets.Interfaces
{
    internal class C_BasePlayerWeapon : InterfaceBase
    {
        public C_BasePlayerWeapon() : base("")
        {

        }

        public  nint m_nNextPrimaryAttackTick = 0x18E0; // GameTick_t
        public  nint m_flNextPrimaryAttackTickRatio = 0x18E4; // float32
        public  nint m_nNextSecondaryAttackTick = 0x18E8; // GameTick_t
        public  nint m_flNextSecondaryAttackTickRatio = 0x18EC; // float32
        public  nint m_iClip1 = 0x18F0; // int32
        public  nint m_iClip2 = 0x18F4; // int32
        public  nint m_pReserveAmmo = 0x18F8; // int32[2]

    }
}
