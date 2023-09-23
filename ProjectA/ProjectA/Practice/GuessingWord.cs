using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.Practice
{
    internal class GuessingWord
    {
        public static void TestOne()
        {
            string SecretWord = "King";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool OutofGuesses = false;
            while(guess != SecretWord)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter the Guess: ");
                    guess = Console.ReadLine();
                    guessCount++;

                }
                else
                {
                    OutofGuesses = true;
                }
                
            }
            if (OutofGuesses)
            {
                Console.WriteLine("You Lose!!");
            }
            else
            {
                Console.WriteLine("You have guessed the word");
            }
            Console.ReadLine();
        }
        
    }
}
