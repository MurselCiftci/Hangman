using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfPets = new List<string>
            {
                "DOG",
                "CAT",
                "SNAKE"
            };
            Random rand = new Random();
            var randomPet = rand.Next(listOfPets.Count);
            Console.WriteLine(listOfPets[randomPet]);

            Console.WriteLine("Insert a character: ");
            char inputLetter = Console.ReadLine()[0];
            string inputLetterToStr = inputLetter.ToString();
            string upperCaseLetter = inputLetterToStr.ToUpper();
            Console.WriteLine(upperCaseLetter);

        }
    }
}
