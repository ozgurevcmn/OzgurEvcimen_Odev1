using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzgurEvcimen_Odev1
{
    internal class Question_6
    {
        public static void Answer()
        {
            
            // Example of Length
            string str = "Hello, World!";
            int length = str.Length;
            Console.WriteLine("Length of the string: " + length);

            // Example of IndexOf
            int index = str.IndexOf("World");
            Console.WriteLine("Index of 'World': " + index);

            // Example of Substring
            string substring = str.Substring(7, 5);
            Console.WriteLine("Substring: " + substring);

            // Example of Contains
            bool contains = str.Contains("Hello");
            Console.WriteLine("Contains 'Hello': " + contains);

            // Example of ToUpper and ToLower
            string upper = str.ToUpper();
            string LOWER = str.ToLower();
            Console.WriteLine("Uppercase: " + upper);
            Console.WriteLine("Lowercase: " + LOWER);

            // Example of Trim
            string trimmed = "   Trimmed String   ".Trim();
            Console.WriteLine("Trimmed: '" + trimmed + "'");

            // Example of Split
            string[] parts = str.Split(',');
            Console.WriteLine("Parts after splitting by comma:");
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }

            // Example of Replace
            string replaced = str.Replace("Hello", "Hi");
            Console.WriteLine("After replacing 'Hello' with 'Hi': " + replaced);

            // Example of Concat
            string concat = String.Concat("This ", "is ", "a ", "concatenated ", "string.");
            Console.WriteLine("Concatenated string: " + concat);

            // Example of Compare
            int compareResult = String.Compare("abc", "def");
            Console.WriteLine("Comparison result: " + compareResult);

            // Example of Equals
            bool isEqual = String.Equals("abc", "abc");
            Console.WriteLine("Are strings equal: " + isEqual);

            // Example of Format
            string formattedString = String.Format("The result is: {0}", 42);
            Console.WriteLine("Formatted string: " + formattedString);
            
        }
    }
}
