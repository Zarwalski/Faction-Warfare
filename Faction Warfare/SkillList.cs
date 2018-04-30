using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SkillList
    {
        public Onehanded onehanded = new Onehanded();
        public TwoHanded twoHanded = new TwoHanded();
        public Polearm polearm = new Polearm();
        public Shield shield = new Shield();
        public Ambidexterity ambidexterity = new Ambidexterity();
        public Dagger dagger = new Dagger();
        public BodyOne bodyOne = new BodyOne();
        public BodyTwo bodyTwo = new BodyTwo();
        public MindOne mindOne = new MindOne();
        public MindTwo mindTwo = new MindTwo();
        public SpiritOne spiritOne = new SpiritOne();
        public SpiritTwo spiritTwo = new SpiritTwo();
        public Archery archery = new Archery();
        public Throwing throwing = new Throwing();
        public LightArmour lightArmour = new LightArmour();
        public MediumArmour mediumArmour = new MediumArmour();
        public HeavyArmour heavyArmour = new HeavyArmour();
        public Surgeon surgeon = new Surgeon();
        public BodyDevelopment bodyDevelopment = new BodyDevelopment();
        public NaturalArmour naturalArmour = new NaturalArmour();
        public Chameleon chameleon = new Chameleon();
        public ResistMagic resistMagic = new ResistMagic();
        public Fearless fearless = new Fearless();
        public AdvancedBodyDevelopment advancedBodyDevelopment = new AdvancedBodyDevelopment();
        public Track track = new Track();
        public Regeneration regeneration = new Regeneration();

        public IEnumerable<ISkill> AllSkills()
        {
            yield return onehanded;
            yield return twoHanded;
            yield return polearm;
            yield return shield;
            yield return ambidexterity;
            yield return dagger;
            yield return bodyOne;
            yield return bodyTwo;
            yield return mindOne;
            yield return mindTwo;
            yield return spiritOne;
            yield return spiritTwo;
            yield return archery;
            yield return throwing;
            yield return lightArmour;
            yield return mediumArmour;
            yield return heavyArmour;
            yield return surgeon;
            yield return bodyDevelopment;
            yield return naturalArmour;
            yield return chameleon;
            yield return resistMagic;
            yield return fearless;
            yield return advancedBodyDevelopment;
            yield return track;
            yield return regeneration;
        }
    }    
}
