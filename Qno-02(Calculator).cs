using System;

namespace App
{
    class ProgramCalculator
    {
        static void Main()
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("-----------------");

           
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

           
            Console.Write("Enter an operator (+, -, *, /): ");
            string op = Console.ReadLine();

            
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
        }
    }
}
