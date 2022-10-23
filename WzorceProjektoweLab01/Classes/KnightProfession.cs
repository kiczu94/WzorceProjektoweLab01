using System;
using System.Collections.Generic;
using System.Text;
using WzorceProjektoweLab01.Interfaces;

namespace WzorceProjektoweLab01.Classes
{
    public class KnightProfession:IProfession
    {
        private string _name = "Knight";
        private ICollection<Skill> _skills;
        public ICollection<Skill> skills { get { return _skills; } set { _skills = value; } }

        public string Name { get {return _name; } }

        public KnightProfession(ICollection<Skill> skills)
        {
            this.skills = skills;
        }

        public void UseSkill(Skill skill)
        {
            Console.WriteLine($"{Name} used his skill {skill.name}");
        }
    }
}
