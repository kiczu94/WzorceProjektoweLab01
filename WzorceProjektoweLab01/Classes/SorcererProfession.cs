using System;
using System.Collections.Generic;
using System.Text;
using WzorceProjektoweLab01.Interfaces;

namespace WzorceProjektoweLab01.Classes
{
    public class SorcererProfession : IProfession
    {
        private string _name = "Sorcerer";
        private ICollection<Skill> _skills;
        public ICollection<ISpell> magicAttacks { get; set; }
        public ICollection<Skill> skills { get {return _skills; } set {_skills=value; } }
        public string Name { get { return _name; } }

        public SorcererProfession(ICollection<Skill> skills, ICollection<ISpell> spells)
        {
            this.skills = skills;
            this.magicAttacks = spells;
        }

        public void UseSkill(Skill skill)
        {
            Console.WriteLine($"{Name} used his skill {skill.name}");
        }
    }
}
