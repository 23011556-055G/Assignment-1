﻿using System;

namespace App
{
    class ProgramEvenOdd
    {
        static void Main()
        {
           
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

           
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is EVEN.");
            }
            else
            {
                Console.WriteLine("The number is ODD.");
            }
        }
    }
}

