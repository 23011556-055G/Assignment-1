using System;

namespace App
{
    class SumNaturalNumbers
    {
        static void Main()
        {
            Console.WriteLine("Sum of Natural Numbers");
            Console.WriteLine("----------------------");

            Console.Write("Enter a positive number (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 1)
            {
                Console.WriteLine("Please enter a number greater than 0.");
            }
            else
            {
                int sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }

                Console.WriteLine("The sum of natural numbers from 1 to " + n + " is: " + sum);
            }
        }
    }
}

