// See https://aka.ms/new-console-template for more information
using System;

namespace FunctionDemo
{
    class Program
    {
        static int Add(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;
        static int Multiply(int a, int b) => a * b;

        static void Main(string[] args)
        {
            int num1 = 40, num2 = 20;
            Console.WriteLine("Add: " + Add(num1, num2));
            Console.WriteLine("Subtract: " + Subtract(num1, num2));
            Console.WriteLine("Multiply: " + Multiply(num1, num2));
        }
    }
}
