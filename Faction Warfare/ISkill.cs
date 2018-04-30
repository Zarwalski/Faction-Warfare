namespace ConsoleApp2
{
    public interface ISkill
    {
        string Description { get; }
        string SkillName { get; }
        int PointsToLearn { get; }
        bool Advanced { get; }
        bool Learned { get; set; }
        int Xp { get;set; }
        int ActiveSkills { get; }
    }

    public class Onehanded : ISkill
    {
        public string Description => "Skill needed for the use of one-handed weapons";
        public string SkillName => "One-Handed Weapon Use";
        public int PointsToLearn => 1;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class TwoHanded : ISkill
    {
        public string Description => "Skill needed for the use of two-handed weapons";
        public string SkillName => "Two-Handed Weapon Use";
        public int PointsToLearn => 2;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class Polearm : ISkill
    {
        public string Description => "Skill needed for the use of polearms";
        public string SkillName => "Polearm Use";
        public int PointsToLearn => 3;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class Shield : ISkill
    {
        public string Description => "Skill needed for the use of shields";
        public string SkillName => "Shield Use";
        public int PointsToLearn => 1;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class Ambidexterity : ISkill
    {
        public string Description => "Skill needed for the use of two one-handed weapons at a time";
        public string SkillName => "Ambidexterity";
        public int PointsToLearn => 1;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class Dagger : ISkill
    {
        public string Description => "Skill needed for the use of daggers";
        public string SkillName => "Dagger Use";
        public int PointsToLearn => 0;
        public bool Advanced => false;
        public bool Learned { get; set; } = true;
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class BodyOne : ISkill
    {
        public string Description => "Skill needed for casting lesser body magic";
        public string SkillName => "Lesser Body Magic";
        public int PointsToLearn => 2;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 2;
    }

    public class BodyTwo : ISkill
    {
        public string Description => "Skill needed for casting greater body magic";
        public string SkillName => "Greater Body Magic";
        public int PointsToLearn => 4;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 4;
    }

    public class MindOne : ISkill
    {
        public string Description => "Skill needed for casting lesser mind magic";
        public string SkillName => "Lesser Mind Magic";
        public int PointsToLearn => 2;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 2;
    }

    public class MindTwo : ISkill
    {
        public string Description => "Skill needed for casting greater mind magic";
        public string SkillName => "Greater Mind Magic";
        public int PointsToLearn => 4;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 4;
    }

    public class SpiritOne : ISkill
    {
        public string Description => "Skill needed for casting lesser spirit magic";
        public string SkillName => "Lesser Spirit Magic";
        public int PointsToLearn => 2;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 2;
    }

    public class SpiritTwo : ISkill
    {
        public string Description => "Skill needed for casting greater spirit magic";
        public string SkillName => "Greater Spirit Magic";
        public int PointsToLearn => 4;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 4;
    }

    public class Archery : ISkill
    {
        public string Description => "Skill needed for use of bows and crossbows";
        public string SkillName => "Archery";
        public int PointsToLearn => 3;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class Throwing : ISkill
    {
        public string Description => "Skill needed for use of thrown weapons";
        public string SkillName => "Thowing Weapon Use";
        public int PointsToLearn => 1;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class LightArmour : ISkill
    {
        public string Description => "Skill needed for use of light armour";
        public string SkillName => "Light Armour Use";
        public int PointsToLearn => 1;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class MediumArmour : ISkill
    {
        public string Description => "Skill needed for use of medium armour";
        public string SkillName => "Medium Armour Use";
        public int PointsToLearn => 2;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class HeavyArmour : ISkill
    {
        public string Description => "Skill needed for use of heavy armour";
        public string SkillName => "Heavy Armour Use";
        public int PointsToLearn => 3;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class Surgeon : ISkill
    {
        public string Description => "Skill needed for use of surgery kits";
        public string SkillName => "Surgeon";
        public int PointsToLearn => 2;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 1;
    }

    public class BodyDevelopment : ISkill
    {
        public string Description => "Skill denoting physical toughness";
        public string SkillName => "Body Development";
        public int PointsToLearn => 3;
        public bool Advanced => false;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class NaturalArmour : ISkill
    {
        public string Description => "Skill denoting fur or tough hide, granting extra defence";
        public string SkillName => "Natural Armour";
        public int PointsToLearn => 0;
        public bool Advanced => true;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class Chameleon : ISkill
    {
        public string Description => "Skill denoting one's ability to blend in with the shadows";
        public string SkillName => "Chameleon";
        public int PointsToLearn => 0;
        public bool Advanced => true;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 1;
    }

    public class ResistMagic : ISkill
    {
        public string Description => "Skill denoting one's ability to inherently resist offencive magic";
        public string SkillName => "Resist Magic";
        public int PointsToLearn => 0;
        public bool Advanced => true;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class Fearless : ISkill
    {
        public string Description => "Skill denoting one's ability to resist fear causing effects";
        public string SkillName => "Fearless";
        public int PointsToLearn => 0;
        public bool Advanced => true;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class AdvancedBodyDevelopment : ISkill
    {
        public string Description => "Skill denoting one's increasing physical fortitude";
        public string SkillName => "Advanced Body Development";
        public int PointsToLearn => 0;
        public bool Advanced => true;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }

    public class Track : ISkill
    {
        public string Description => "Skill denoting one's ability to find hidden objects";
        public string SkillName => "Track";
        public int PointsToLearn => 0;
        public bool Advanced => true;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 1;
    }

    public class Regeneration : ISkill
    {
        public string Description => "Skill denoting one's ability to regrow lost limbs";
        public string SkillName => "Regeneration";
        public int PointsToLearn => 0;
        public bool Advanced => true;
        public bool Learned { get; set; }
        public int Xp { get; set; }
        public int ActiveSkills => 0;
    }
}

