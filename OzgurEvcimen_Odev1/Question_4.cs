using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzgurEvcimen_Odev1
{
    internal class Question_4
    {
        private static int guessedNumberr;

        public static void Answer()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            while (true)
            {
                Console.WriteLine("Guess the number between 1 to 10");
                string guessedNumber = Console.ReadLine();

                if (int.TryParse(guessedNumber, out guessedNumberr))
                {
                    if (guessedNumberr == randomNumber)
                    {
                        Console.WriteLine("You guessed RIGHT!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try againg :(");
                    }
                }
                else 
                {
                    Console.WriteLine("Please enter a valid number!");
                }
            }
        }
    }
}
