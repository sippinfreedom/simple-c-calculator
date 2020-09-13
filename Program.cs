using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(num1 + num2);
            } else if (op == "-")
            {
                Console.Write(num1 - num2);
            }
             else if (op == "/")
            {
                Console.Write(num1 / num2);
            }
             else if (op == "*")
            {
                Console.Write(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

    Console.ReadLine();
        }
    }
}
