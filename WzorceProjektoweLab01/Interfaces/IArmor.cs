using System;
using System.Collections.Generic;
using System.Text;

namespace WzorceProjektoweLab01.Interfaces
{
    public interface IArmor : IItem
    {
        int defencePoints { get; set; }
        void GetDamage(int damageTaken);
    }
}
