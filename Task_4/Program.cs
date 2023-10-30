using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 4
//Реалізуйте додаток із другого практичного завдання
//за допомогою виклику Invoke.
namespace Task_4
{
    public delegate void Arifmetic(int a, int b);
    internal class Program
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Diff(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public static void Mult(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integer numbers for the Arifmetic operations: ");
            int a=Int32.Parse(Console.ReadLine());
            int b=Int32.Parse(Console.ReadLine());
            Arifmetic operation = new Arifmetic(Sum);
            operation += Diff;
            operation += Mult;
            operation.Invoke(a, b);
        }
    }
}
