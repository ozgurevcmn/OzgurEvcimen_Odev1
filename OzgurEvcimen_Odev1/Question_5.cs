using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OzgurEvcimen_Odev1
{
    internal class Question_5
    {
        public static void Answer() 
        {
            Console.WriteLine("Enter a number to check if it is perfect number");
            string number = Console.ReadLine();
            UInt128 Number;
            UInt128 total = 0;

            List<UInt128> divisors = new List<UInt128>();

            if (UInt128.TryParse(number, out Number))
            {
                for (UInt128 i = 1; i < Number; i++)
                {
                    if (Number % i == 0)
                    {
                        total += i;
                        divisors.Add(i);
                    }
                }
                if (total == Number)
                {
                    Console.WriteLine($"{Number} is a perfect!\nDivisors={{ {String.Join(", ",divisors)}}}");
                }
                else
                {
                    Console.WriteLine("Your number is not perfect.");
                }

            }
            else
            {
                Console.WriteLine("Please enter a valid number!");
            }

        }
    }
}
