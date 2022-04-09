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
            string randomPet = petList[rand.Next(petList.Length)];

            var randomPetSeparateLetters = randomPet.ToCharArray();
            
            /*
            for (int i = 0; i < randomPet.Length; i++)
                Console.WriteLine(randomPet[i]);
            */

            // Ask the user to fill in a character
            Console.WriteLine("Insert a character: ");
            char inputLetter = Console.ReadLine()[0];
            string inputLetterToStr = inputLetter.ToString();
            string inputUpperCaseLetter = inputLetterToStr.ToUpper();
            
            bool letterFoundInRandomWord = Array.Exists(randomPetSeparateLetters, element => element.Equals(inputUpperCaseLetter));
            /*
            bool inputCharIsPartOfRandPet = randomPetSeparateLetters.Contains(upperCaseLetter); 
            */       
            
        }
    }
}
