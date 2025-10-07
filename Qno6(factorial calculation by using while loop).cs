using System;

namespace App
{
    class FactorialCalculator
    {
        static void Main()
        {
            Console.WriteLine("Factorial Calculator");
            Console.WriteLine("---------------------");

            Console.Write("Enter a non-negative number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                long factorial = 1;
                int i = 1;

                while (i <= number)
                {
                    factorial *= i;
                    i++;
                }

                Console.WriteLine("Factorial of " + number + " is: " + factorial);
            }
        }
    }
}

