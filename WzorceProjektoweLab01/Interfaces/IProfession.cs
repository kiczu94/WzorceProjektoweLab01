using System;
using System.Collections.Generic;
using System.Text;
using WzorceProjektoweLab01.Classes;

namespace WzorceProjektoweLab01.Interfaces
{
    public interface IProfession
    {
        public string Name { get; }
        ICollection<Skill> skills { get; set; }

        void UseSkill(Skill skill);
    }
}
