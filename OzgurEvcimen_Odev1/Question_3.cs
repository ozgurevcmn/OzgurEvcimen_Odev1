using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzgurEvcimen_Odev1
{
    internal class Question_3
    {   
        public static void Answer()
        {
            WhileExample();
            Console.WriteLine("\n");
            DoWhileExample();
        }

        public static void WhileExample()
        {
            int counter = 0;
            Console.WriteLine("Starting a 'while' loop example.");

            while (counter < 5)
            {
                Console.WriteLine($"While loop iteration: {counter}");
                counter++;
            }

            Console.WriteLine("The 'while' loop has completed.");
        }
        public static void DoWhileExample()
        {
            int counter = 0;
            Console.WriteLine("Starting a 'do-while' loop example.");

            do
            {
                Console.WriteLine($"Do-while loop iteration: {counter}");
                counter++;
            } while (counter < 5);

            Console.WriteLine("The 'do-while' loop has completed.");
        }
    }
}
