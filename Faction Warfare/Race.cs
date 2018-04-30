namespace ConsoleApp2

{

    public class Race

    {

        public string Name;

        public string AdvancedSkillOne;

        public string AdvancedSkillTwo;





        public static Race Beastman()

        {

            return new Race

            {

                Name = "Beastman",

                AdvancedSkillOne = "Natural Armour",

                AdvancedSkillTwo = "Chameleon",

            };

        }



        public static Race Dwarf()

        {

            return new Race

            {

                Name = "Dwarf",

                AdvancedSkillOne = "Resist Magic",

                AdvancedSkillTwo = "Fearless",

            };

        }



        public static Race Elf()

        {

            return new Race

            {

                Name = "Elf",

                AdvancedSkillOne = "Chameleon",

                AdvancedSkillTwo = "Track",

            };

        }



        public static Race DarkElf()

        {

            return new Race

            {

                Name = "Dark Elf",

                AdvancedSkillOne = "Resist Magic",

                AdvancedSkillTwo = "Chameleon",

            };

        }



        public static Race Human()

        {

            return new Race

            {

                Name = "Human",

                AdvancedSkillOne = "Versatility",

                AdvancedSkillTwo = null,

            };

        }



        public static Race Goblin()

        {

            return new Race

            {

                Name = "Goblin",

                AdvancedSkillOne = "Fearless",

                AdvancedSkillTwo = "Track",

            };

        }



        public static Race Troll()

        {

            return new Race

            {

                Name = "Troll",

                AdvancedSkillOne = "Regeneration",

                AdvancedSkillTwo = "Resist Magic",

            };

        }

        public static Race Ogre()

        {

            return new Race

            {

                Name = "Ogre",

                AdvancedSkillOne = "Advanced Body Development",

                AdvancedSkillTwo = "Natural Armour",

            };

        }



        public static Race Orc()

        {

            return new Race

            {

                Name = "Orc",

                AdvancedSkillOne = "Natural Armour",

                AdvancedSkillTwo = "Fearless",

            };

        }

    }

}