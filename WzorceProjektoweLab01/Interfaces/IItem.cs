using System;
using System.Collections.Generic;
using System.Text;

namespace WzorceProjektoweLab01.Interfaces
{
    public interface IItem
    {
        string itemType { get; set; }
        void Use();
    }
}
