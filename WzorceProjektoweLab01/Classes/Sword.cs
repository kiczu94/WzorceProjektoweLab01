using System;
using System.Collections.Generic;
using System.Text;
using WzorceProjektoweLab01.Interfaces;

namespace WzorceProjektoweLab01.Classes
{
    public class Sword : IWeapon
    {
        private int _normalDamage;
        private int _magicDamage;
        private string _itemType;
        public int normalDamage { get => _normalDamage; set => _normalDamage = value; }
        public int magicDamage { get => _magicDamage; set => _magicDamage = value; }
        public string itemType { get => _itemType; set => _itemType = value; }


        public Sword(int normalDamage, int magicDamage, string itemType = "sword")
        {
            _normalDamage = normalDamage;
            _magicDamage = magicDamage;
            _itemType = itemType;
        }

        public void Use()
        {
            Console.WriteLine($"Used {_itemType}");
        }
    }
}
