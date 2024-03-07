using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzgurEvcimen_Odev1
{
    internal class Odev1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter question number 1-7 or write 'exit' to quit:");
                string input = Console.ReadLine();
                int questionNumber;

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting program.");
                    break;
                }

                if (int.TryParse(input, out questionNumber))
                {
                    switch (questionNumber)
                    {
                        case 1:
                            Question_2_1.Answer();
                            break;
                        case 2:
                            Question_2_1.Answer();
                            break;
                        case 3:
                            Question_3.Answer();
                            break;
                        case 4:
                            Question_4.Answer();
                            break;
                        case 5:
                            Question_5.Answer();
                            break;
                        case 6:
                            Question_6.Answer();
                            break;
                        case 7:
                            Question_7.Answer();
                            break;
                        default:
                            Console.WriteLine("Invalid question number.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number.\n");
                }
            }
        }
    }
}
