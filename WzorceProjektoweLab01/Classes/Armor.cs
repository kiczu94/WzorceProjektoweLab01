using System;
using System.Collections.Generic;
using System.Text;
using WzorceProjektoweLab01.Interfaces;

namespace WzorceProjektoweLab01.Classes
{
    public class Armor : IArmor
    {
        private int _defencePoints;
        private string _itemType = "Armor";
        public int defencePoints { get { return _defencePoints; } set { _defencePoints = value; } }
        public string itemType { get { return _itemType; } set { _itemType = value; } }

        public void GetDamage(int damageTaken)
        {
            Console.WriteLine("Armor took damage");
        }

        public void Use()
        {
            Console.WriteLine("Armor used");
        }
    }
}
