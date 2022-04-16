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
            /* Select a random pet from the listPet
            // int randPetListIndex = rand.Next(petList.Count);
            // int randIndexPetList = rand.Next(petList.Count);
             string randPet = randIndexPetList.ToString();*/



            // Take random pet as a string from a string list
            string randomPetFromPetList = petList[rand.Next(petList.Count)];
            
            List<char> petLetters = new List<char>();
            petLetters.AddRange(randomPetFromPetList);

            // Ask the user to fill in a character
            Console.WriteLine("Insert a character: ");
            char inputLetter = Console.ReadLine()[0];
          //  string inputLetterToStrUpperCase = inputLetter.ToString().ToUpper();



            
            
            // creates underscores for each letter of the random pet
            List<char> hangmanSecretLetterUnderscores = new List<char>();
            char underscore = '_';
            
            for (int i = 0; i < petLetters.Count; i++)
            {
                hangmanSecretLetterUnderscores.Add(underscore);
            }
            
            Console.WriteLine(string.Join(" ", hangmanSecretLetterUnderscores));

            
            
            
            // bool found = false;
            for (int i = 0; i < randomPetFromPetList.Length;i++)
            {
                if (inputLetter == petLetters[i])
                {
                    hangmanSecretLetterUnderscores.RemoveAt(i);
                    hangmanSecretLetterUnderscores.Insert(i, inputLetter);
                    // found = true;
                }

            }

            //if (inputLetter == petLetters[0])
            //    found = true;

            //if (inputLetter == petLetters[1])
            //    found = true;

            //if (inputLetter == petLetters[2])
            //    found = true;





        }
    }
}
