using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CharacterRaw

    {

        public string Name { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; } = 0;

        public SkillList Skill = new SkillList();

        public Race Race = new Race();

        public Attributes Attributes = new Attributes();

        public Item ItemOne { get; set; } = null;

        public Item ItemTwo { get; set; } = null;

        public Item ItemThree { get; set; } = null;

    }
}
