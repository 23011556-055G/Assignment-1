using System;

namespace App
{
    class MultiplicationTable
    {
        static void Main()
        {
            Console.WriteLine("Multiplication Table");
            Console.WriteLine("---------------------");

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMultiplication Table of " + number + ":");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " x " + i + " = " + (number * i));
            }
        }
    }
}


