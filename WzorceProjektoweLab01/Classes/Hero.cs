using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WzorceProjektoweLab01.Interfaces;

namespace WzorceProjektoweLab01.Classes
{
    public class Hero : ICharacter
    {
        private IProfession _profession;
        public int _healthPoints;
        private int _magicPoints;
        private Equipment _equipment;
        public IProfession profession { get { return _profession; } set { _profession = value; } }
        public int healthPoints { get { return _healthPoints; } set { _healthPoints = value; } }
        public int magicPoints { get { return _magicPoints; } set { _magicPoints = value; } }
        public Equipment equipment { get { return _equipment; } set { _equipment = value; } }

        public Hero(Equipment equipment, IProfession profession, int healthPoints, int magicPoints)
        {
            this.equipment = equipment;
            this.profession = profession;
            this.healthPoints = healthPoints;
            this.magicPoints = magicPoints;
        }

        public void Attack()
        {
            Console.WriteLine($"{profession.Name} attacked.");
        }

        public void UseEq(IItem item)
        {
            Console.WriteLine($"{profession.Name} used {item.itemType}");
        }

        public void Walk(string direction)
        {
            Console.WriteLine($"{profession.Name} walk {direction}");
        }
    }
}
