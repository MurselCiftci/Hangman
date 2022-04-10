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
            
            // Create a list of Pets
            List<string> petList = new List<string>()
            {
                "CAT",
                "DOG",
                "SNAKE",
                "GIRAFFE"
            };
            // Select a random pet from the listPet
            // int randPetListIndex = rand.Next(petList.Count);
            // int randIndexPetList = rand.Next(petList.Count);
            // string randPet = randIndexPetList.ToString();
            
            // Take random pet as a string from a string list
            string randomPetFromPetList = petList[rand.Next(petList.Count)];



            // Ask the user to fill in a character
            Console.WriteLine("Insert a character: ");
            char inputLetter = Console.ReadLine()[0];
            string inputLetterToStr = inputLetter.ToString();
            string inputUpperCaseLetter = inputLetterToStr.ToUpper();



            /*
            bool found = false;
            for (int i = 0; i < randomPetSeparateLetters.Length; i++)
            {
                if (inputUpperCaseLetter == randomPetSeparateLettersToStr)
                {

                    found = true;
                }
            }
            */
            

           

        }
    }
}
