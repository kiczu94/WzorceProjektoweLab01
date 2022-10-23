using System;
using System.Collections.Generic;
using System.Text;
using WzorceProjektoweLab01.Interfaces;

namespace WzorceProjektoweLab01.Classes
{
    public class Equipment
    {
        private ICollection<IItem> _backpackEquipment;
        private ICollection<IItem> _onCharacterEquipment;
        public ICollection<IItem> BackpackEquipment
        {
            get { return _backpackEquipment; }
            set { _backpackEquipment = value; }
        }

        public ICollection<IItem> onCharacterEquipment
        {
            get { return _onCharacterEquipment; }
            set { _onCharacterEquipment = value; }
        }

        public Equipment(ICollection<IItem> backpack, ICollection<IItem> itemsOnCharacter)
        {
            BackpackEquipment = backpack;
            onCharacterEquipment = itemsOnCharacter;
        }

        public void ThrowAway(IItem item)
        {
            Console.WriteLine($"{item.itemType} thrown.");
        }
    }
}
