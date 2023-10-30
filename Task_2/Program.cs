using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 2
//Створіть додаток для виконання арифметичних опе-
//рацій. Підтримувані операції:
//■ Додавання двох чисел;
//■ Віднімання двох чисел;
//■ Множення двох чисел.
//Код програми обов’язково має використати механізм
//делегатів.
namespace Task_2
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
            Arifmetic operation = new Arifmetic(Sum);
            operation += Diff;
            operation += Mult;
            operation(5, 8);
        }
    }
}
