using System;
using System.Collections.Generic;
using System.Text;
using WzorceProjektoweLab01.Interfaces;

namespace WzorceProjektoweLab01.Classes
{
    public class OffensiveSpell : ISpell, IWeapon
    {
        int _normalDamage;
        int _magicDamage;
        string _itemType;
        int _magicPointCost;

        public int normalDamage { get => _normalDamage; set => _normalDamage = value; }
        public int magicDamage { get => _magicDamage; set => _magicDamage = value; }
        public string itemType { get => _itemType; set => _itemType = value; }
        public int magicPointCost { get => _magicPointCost; set => _magicPointCost = value; }

        public OffensiveSpell(int magicDamage, string itemType="Scroll", int magicPointCost=20, int normalDamage=0)
        {
            _normalDamage = 0;
            _magicDamage = magicDamage;
            _itemType = itemType;
            _magicPointCost = magicPointCost;
        }

        public void Use()
        {
            Console.WriteLine($"Used {itemType}, which costs {magicPointCost} MP");
        }
    }
}
