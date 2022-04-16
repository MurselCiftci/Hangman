using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize randomizer 
            Random rand = new Random();

            // Create a list of Pets
            List<string> petList = new List<string>()
            {
                "CAT",
                "DOG",
                "SNAKE",
                "GIRAFFE"
            };

            bool gameRunning = true;

            while (gameRunning == true)
            {
                // In section below initialize a new game
                // Take random pet as a string from a string list
                string randomPetFromPetList = petList[rand.Next(petList.Count)];

                // Split the random pet word into characters of each letter
                List<char> petLetters = new List<char>();
                petLetters.AddRange(randomPetFromPetList);

                // Creates a list of underscores for each letter of the random pet
                List<char> hangmanSecretLetterUnderscores = new List<char>();
                char underscore = '_';

                for (int i = 0; i < petLetters.Count; i++)
                {
                    hangmanSecretLetterUnderscores.Add(underscore);
                }

                while (true)
                {
                    // Ask the user to fill in a character
                    Console.WriteLine("Insert a character: ");
                    char inputLetter = Console.ReadLine()[0];
                    Console.Clear();

                    // bool found = false;
                    // Checks whether inputletter matches a letter from random pet, if so it replaces underscore in right position for letter
                    for (int i = 0; i < randomPetFromPetList.Length; i++)
                    {
                        if (inputLetter == petLetters[i])
                        {
                            Console.Clear();
                            Console.WriteLine($"Good job! The letter {inputLetter} is in the secret word!");
                            hangmanSecretLetterUnderscores.RemoveAt(i);
                            hangmanSecretLetterUnderscores.Insert(i, inputLetter);
                            Console.WriteLine(string.Join(" ", hangmanSecretLetterUnderscores));
                            // found = true;
                        }
                        else
                        {
                            Console.WriteLine($"{inputLetter} does not exist in the secret word");
                        }
                    }
                    break;
                }
                break;
            }
        }
    }
}
