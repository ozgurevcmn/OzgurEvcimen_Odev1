using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OzgurEvcimen_Odev1
{
    internal class Question_7
    {
        public static void Answer()
        {
            int numberOfStudents;
            string studentName;
            int firstExamResult;
            int secondExamResult;
            int thirdExamResult;


            List<Tuple<string, int, int, int, int>> studentsList = new List<Tuple<string, int, int, int, int>>();

            Console.WriteLine("How many students will you enter?");
            string numberOfStudentsStr = Console.ReadLine();
            if (int.TryParse(numberOfStudentsStr, out numberOfStudents))
            {
                for (int i = 1; i <= numberOfStudents; i++ )
                {
                    Console.WriteLine("Enter student name and surname...");
                    studentName = Console.ReadLine();

                    Console.WriteLine("Enter first exam result...");
                    string firstExamResultStr = Console.ReadLine();
                    if (int.TryParse(firstExamResultStr, out firstExamResult) && firstExamResult >= 0 && firstExamResult <= 100)
                    {
                        Console.WriteLine("Enter second exam result...");
                        string secondExamResultStr = Console.ReadLine();
                        if (int.TryParse(secondExamResultStr, out secondExamResult) && secondExamResult >= 0 && secondExamResult <= 100)
                        {
                            Console.WriteLine("Enter third exam result...");
                            string thirdExamResultStr = Console.ReadLine();
                            if (int.TryParse(thirdExamResultStr, out thirdExamResult) && thirdExamResult >= 0 && thirdExamResult <= 100)
                            {
                                int avarageResult = (firstExamResult + secondExamResult + thirdExamResult) / 3;
                                studentsList.Add(new Tuple<string, int, int, int, int>(studentName, firstExamResult, secondExamResult, thirdExamResult, avarageResult));
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid third exam result!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid second exam result!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid first exam result!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number!");
            }
            foreach(var student in studentsList)
            {
                Console.WriteLine($"Student Name:{student.Item1}, First Exam:{student.Item2}, Second Exam:{student.Item3}, Third Exam:{student.Item4}, Average Result:{student.Item5}\n");
            }
        }
    }
}
