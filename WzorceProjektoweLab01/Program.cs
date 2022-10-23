using System;
using System.Collections.Generic;
using System.Linq;
using WzorceProjektoweLab01.Classes;
using WzorceProjektoweLab01.Interfaces;

namespace WzorceProjektoweLab01
{
    class Program
    {
        static void Main(string[] args)
        {
            var knightArmor = new Armor();
            var knightSword = new Sword(normalDamage:20, magicDamage:20);
            var knightEquipment = new Equipment(backpack: new List<IItem> { knightArmor }, itemsOnCharacter: new List<IItem> { knightSword });
            var knightSkills = new List<Skill> { new Skill("Cut") };
            var knightProffesion = new KnightProfession(knightSkills);
            var knight = new Hero(equipment:knightEquipment, profession: knightProffesion, healthPoints: 200, magicPoints:10);
            var sorcererArmor = new Armor();
            var sorcererSpell = new List<ISpell> { new OffensiveSpell(normalDamage: 20, magicDamage: 20) };
            var sorcererSword = new Sword(normalDamage: 20, magicDamage: 20);
            var sorcererEquipment = new Equipment(backpack: new List<IItem> { sorcererArmor }, itemsOnCharacter: new List<IItem> { sorcererSword });
            var sorcererSkill = new List<Skill> { new Skill("Cast") };
            var sorcererProfession = new SorcererProfession(sorcererSkill, sorcererSpell);
            var sorcerer = new Hero(equipment: sorcererEquipment, profession: sorcererProfession, healthPoints: 50, magicPoints: 200);

            knight.Attack();
            knight.UseEq(knight.equipment.onCharacterEquipment.First());
            knight.Walk("South");
            knight.profession.UseSkill(knight.profession.skills.First());
            knight.equipment.ThrowAway(knight.equipment.BackpackEquipment.First());
            knight.equipment.onCharacterEquipment.First().Use();

            sorcerer.Attack();
            sorcerer.UseEq(sorcerer.equipment.onCharacterEquipment.First());
            sorcerer.Walk("North");
            sorcerer.profession.UseSkill(sorcerer.profession.skills.First());
            sorcerer.equipment.ThrowAway(sorcerer.equipment.BackpackEquipment.First());
            sorcerer.equipment.onCharacterEquipment.First().Use();

            Console.ReadLine();
        }
    }
}
