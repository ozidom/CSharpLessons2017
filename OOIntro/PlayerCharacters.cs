using System;
using System.Collections.Generic;

namespace CSharpLessons
{
    public enum PlayerCharacterClass
    {
        Fighter,
        Ranger,
        Cleric,
        MagicUser,
        Thief,
        Paladin
    }

    public enum Race
    {
        Human,
        Elf,
        Dwarf,
        Gnome,
        Halfling,
        HalfElf
	}

	public class PlayerCharacter
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public PlayerCharacterClass PlayersClass { get; set; }
        public Race PlayersRace{ get; set; }
        public int HitPoints { get; set; }
        public int ArmourClass { get; set; }

        public PlayerCharacter()
        {
        }


    }

    public static class PlayerCharactedFactory
    {
        public static List<PlayerCharacter> CreatePersons()
        {
            return new List<PlayerCharacter>()
            { 
                new PlayerCharacter(){ID=1, Name="John", Age=32, PlayersRace=Race.Human,PlayersClass=PlayerCharacterClass.Paladin,HitPoints=12,ArmourClass=2},
                new PlayerCharacter(){ID=10, Name="Elfy", Age=321, PlayersRace=Race.Elf,PlayersClass=PlayerCharacterClass.Thief,HitPoints=12,ArmourClass=5},
                new PlayerCharacter(){ID=101, Name="Steve the Mage", Age=82, PlayersRace=Race.Human,PlayersClass=PlayerCharacterClass.MagicUser,HitPoints=4,ArmourClass=9},
                new PlayerCharacter(){ID=102, Name="Ranger Joe", Age=492, PlayersRace=Race.Elf,PlayersClass=PlayerCharacterClass.Ranger,HitPoints=8,ArmourClass=4},
                new PlayerCharacter(){ID=103, Name="Louise the Elf", Age=132, PlayersRace=Race.Human,PlayersClass=PlayerCharacterClass.Cleric,HitPoints=7,ArmourClass=7},
                new PlayerCharacter(){ID=108, Name="Dwarfo", Age=87, PlayersRace=Race.Dwarf,PlayersClass=PlayerCharacterClass.Fighter,HitPoints=10,ArmourClass=2},
                new PlayerCharacter(){ID=109, Name="Clyde Foot II", Age=102, PlayersRace=Race.Gnome,PlayersClass=PlayerCharacterClass.Thief,HitPoints=4,ArmourClass=5},
                new PlayerCharacter(){ID=121, Name="Shorty", Age=67, PlayersRace=Race.Halfling,PlayersClass=PlayerCharacterClass.Thief,HitPoints=7,ArmourClass=6},
				 new PlayerCharacter(){ID=892, Name="OLD ELF", Age=3432, PlayersRace=Race.Human,PlayersClass=PlayerCharacterClass.Paladin,HitPoints=12,ArmourClass=2},
				new PlayerCharacter(){ID=999, Name="YOUNG ELF", Age=89, PlayersRace=Race.Elf,PlayersClass=PlayerCharacterClass.Cleric,HitPoints=12,ArmourClass=5},
				new PlayerCharacter(){ID=1001, Name="GANDALF", Age=2092, PlayersRace=Race.Elf,PlayersClass=PlayerCharacterClass.MagicUser,HitPoints=84,ArmourClass=4},
				new PlayerCharacter(){ID=1002, Name="Aragorn", Age=40, PlayersRace=Race.Human,PlayersClass=PlayerCharacterClass.Ranger,HitPoints=68,ArmourClass=3},
				new PlayerCharacter(){ID=1003, Name="Bilbo", Age=67, PlayersRace=Race.Halfling,PlayersClass=PlayerCharacterClass.Thief,HitPoints=6,ArmourClass=4},
				new PlayerCharacter(){ID=1004, Name="Iyma M", Age=82, PlayersRace=Race.HalfElf,PlayersClass=PlayerCharacterClass.Fighter,HitPoints=10,ArmourClass=2},
				new PlayerCharacter(){ID=1005, Name="Clyde Foot", Age=102, PlayersRace=Race.Gnome,PlayersClass=PlayerCharacterClass.Thief,HitPoints=4,ArmourClass=5},
				new PlayerCharacter(){ID=1005, Name="Shorty II", Age=47, PlayersRace=Race.Halfling,PlayersClass=PlayerCharacterClass.Fighter,HitPoints=17,ArmourClass=3}
            };
        }
    }

}
