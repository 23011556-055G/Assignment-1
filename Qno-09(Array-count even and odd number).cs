using System;

namespace App
{
    class EvenOddCounter
    {
        static void Main()
        {
            int[] numbers = new int[10];
            int evenCount = 0;
            int oddCount = 0;

            Console.WriteLine("Enter 10 integers:");

            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine("\nTotal Even Numbers: " + evenCount);
            Console.WriteLine("Total Odd Numbers: " + oddCount);
        }
    }
}
