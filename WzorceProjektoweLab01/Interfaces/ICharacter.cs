using System;
using System.Collections.Generic;
using System.Text;
using WzorceProjektoweLab01.Classes;

namespace WzorceProjektoweLab01.Interfaces
{
    interface ICharacter
    {
        int healthPoints { get; set; }
        int magicPoints { get; set; }
        Equipment equipment { get; set; }

        void Walk(string direction);
        void UseEq(IItem item);
        void Attack();
    }
}
