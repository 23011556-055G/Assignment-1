using System;

namespace App
{
    class GradeEvaluator
    {
        static void Main()
        {
            Console.WriteLine("Grade Evaluator");
            Console.WriteLine("----------------");

            Console.Write("Enter marks (0-100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid marks. Please enter a value between 0 and 100.");
            }
            else if (marks > 85)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade: B");
            }
            else if (marks >= 55)
            {
                Console.WriteLine("Grade: C");
            }
            else if (marks >= 40)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        }
    }
}

