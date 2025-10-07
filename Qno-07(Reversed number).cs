using System;

namespace App
{
    class ReverseDigits
    {
        static void Main()
        {
            Console.WriteLine("Reverse Digits of a Number");
            Console.WriteLine("--------------------------");

            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int originalNumber = number;
            int reversed = 0;

            while (number != 0)
            {
                int digit = number % 10;     
                reversed = reversed * 10 + digit; 
                number = number / 10;            
            }

            Console.WriteLine("Reversed number of " + originalNumber + " is: " + reversed);
        }
    }
}

