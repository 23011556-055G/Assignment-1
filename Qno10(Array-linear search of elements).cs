using System;

namespace App
{
    class LinearSearch
    {
        static void Main()
        {
            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nEnter a number to search: ");
            int searchValue = Convert.ToInt32(Console.ReadLine());

            
            bool found = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchValue)
                {
                    Console.WriteLine("Number found at position " + (i + 1));
                    found = true;
                    break;
                }
            }

            
            if (!found)
            {
                Console.WriteLine("Number not found in the array.");
            }
        }
    }
}

