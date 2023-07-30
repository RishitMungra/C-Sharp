using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Choice : ");
            char choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case '+':
                    Console.WriteLine("Addition : " + (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("Subtraction : " + (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("Multiplication : " + (num1 * num2));
                    break;

                case '/':
                    Console.WriteLine("Division : " + (num1 / num2));
                    break;

                case '%':
                    Console.WriteLine("Modulo : " + (num1 % num2));
                    break;
            }
        }
    }
}