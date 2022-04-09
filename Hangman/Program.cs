using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pick a random pet in the list of pets below 
            Random rand = new Random();
            string[] petList = { "CAT", "DOG", "SNAKE" };
            Console.WriteLine(petList[rand.Next(0, petList.Length)]);

            // Ask the user to fill in a character
            Console.WriteLine("Insert a character: ");
            char inputLetter = Console.ReadLine()[0];
            string inputLetterToStr = inputLetter.ToString();
            string upperCaseLetter = inputLetterToStr.ToUpper();
            Console.WriteLine(upperCaseLetter);

            /* Check whether the random picked pet has a character that the user filled in
            bool inputCharIsPartOfRandPet = randomPet.Contains(upperCaseLetter); */
        }
    }
}
