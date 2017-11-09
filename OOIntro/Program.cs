using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLessons
{
    class Program
    {
		static void PrintPlayerCharacters(List<PlayerCharacter> playerCharacters, string listName = "Player Character List")
		{
            Console.WriteLine(listName);
            Console.WriteLine("-------------------------");
            playerCharacters.ForEach(pc => Console.WriteLine($"{pc.Name} {pc.PlayersRace} {pc.PlayersClass} Age {pc.Age} "));
            Console.WriteLine();
		}

        static void Main(string[] args)
        {
            Console.WriteLine("Linq - More");

            var playerCharacters = PlayerCharactedFactory.CreatePersons();

            PrintPlayerCharacters(playerCharacters);

            var playerCharactersOver200Years = playerCharacters.Where(pc => pc.Age > 200);
            PrintPlayerCharacters(playerCharactersOver200Years.ToList(), "PC's over 200");























            //Now lets say we want the PC over 200 who elves

            var playerCharactersOver200YearsElfs = playerCharacters.Where(pc => pc.Age > 200).Where(pc => pc.PlayersRace == Race.Elf);
            PrintPlayerCharacters(playerCharactersOver200YearsElfs.ToList(), "PC's over 200 who are Elves");















            //Now say we need to have the age of the oldest PC's Who are Dwarf or HalfElf 
            var oldestDwarfOrHalfElf = playerCharacters.Where(pc => pc.PlayersRace == Race.Dwarf || pc.PlayersRace == Race.HalfElf).Max(pec => pec.Age);
            Console.WriteLine($"The oldest Dwarf/Half Elf is {oldestDwarfOrHalfElf}");


















            //Now we just want the number of Elves
            var numberElves = playerCharacters.Where(pc => pc.PlayersRace == Race.Elf).Count();
            Console.WriteLine($"The number of elves is {numberElves}");














            // Now we just want four youngest
            var fourYoungestFailed = playerCharacters.OrderBy(pc => pc.Age).Take(4);
            PrintPlayerCharacters(fourYoungestFailed.ToList(), "PC's youngest four");
















            //Deferred Execution - lets find the characters 
            var charactersVeryHardToHit = playerCharacters.Where(pc => pc.ArmourClass < 5);
			//can someone tell me what is the state of charactersVeryHardToHit on this line
			if (charactersVeryHardToHit.Count() > 1)
            {
                Console.WriteLine("We have some hard to hit characters");
            }











            //More Linq 
            // http://linqsamples.com/

            // Homework
            //http://markheath.net/post/lunchtime-linq-challenge-2

            //More Chaining
            //https://www.red-gate.com/simple-talk/dotnet/net-framework/linq-secrets-revealed-chaining-and-debugging/

		}


    }
}