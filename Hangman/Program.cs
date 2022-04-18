using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // number of  max guesses allowed 
            int MAX_GUESSES = 10;

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

                // keep track of amount of guesses
                int guesses = 0;

                // Take random pet as a string from a string list
                string randomPetFromPetList = petList[rand.Next(petList.Count)];

                // Split the random pet word into characters of each letter
                List<char> petLetters = new List<char>();
                petLetters.AddRange(randomPetFromPetList);

                // Creates a list of underscores for each letter of the random pet
                List<char> currentGameWord = new List<char>();
                char underscore = '_';

                for (int i = 0; i < petLetters.Count; i++)
                {
                    currentGameWord.Add(underscore);
                }

                Console.WriteLine(string.Join(" ", currentGameWord));
          
                while (true)
                {
                    if (guesses >= MAX_GUESSES)
                    {
                        Console.WriteLine("Game over, you are out of guesses");
                        break;
                    }

                    // Ask the user to fill in a character
                    Console.WriteLine("\nInsert a character: ");
                    char inputLetter = Console.ReadLine()[0];

                    // Every time the user goes through this loop a guess amount is added
                    guesses++;

                    bool found = false;

                    // Checks whether inputletter matches a letter from random pet, if so it replaces underscore in right position for letter
                    for (int i = 0; i < randomPetFromPetList.Length; i++)
                    {
                        if (inputLetter == petLetters[i])
                        {
                            Console.Clear();
                            currentGameWord.RemoveAt(i);
                            currentGameWord.Insert(i, inputLetter);
                            Console.WriteLine(string.Join(" ", currentGameWord));
                            Console.WriteLine($"\nGood job! The letter {inputLetter} is in the secret word!");
                            found = true;
                        }
                    }

                    if (found == false)
                    {
                        Console.Clear();
                        Console.WriteLine(string.Join(" ", currentGameWord));
                        Console.WriteLine("\nYou guessed wrong!");
                    }

                    // Win logic
                    string liveCurrentWord = string.Join(" ", currentGameWord);
                    string petLettersSeparated = string.Join(" ", petLetters);

                    if (liveCurrentWord == petLettersSeparated)
                    {
                        Console.WriteLine("You won!");
                        break;
                    }
                }
                break;
            }
        }
    }
}
