using System;
using System.Collections.Generic;
using System.Text;

namespace WzorceProjektoweLab01.Interfaces
{
    public interface IWeapon:IItem
    {
        int normalDamage { get; set; }
        int magicDamage { get; set; }
    }
}
