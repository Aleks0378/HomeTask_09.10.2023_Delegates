using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 3
//Створіть додатки для виконання арифметичних операцій.
//Підтримувані операції:
//■ Перевірка числа на парність;
//■ Перевірка числа на непарність;
//■ Перевірка на просте число;
//■ Перевірка на число Фібоначчі.
//Обов’язково використовуйте делегат типу Predicate.
namespace Task_3
{
    public delegate bool CheckNum<T>(T num);
    internal class Program
    {
        public static bool Even(int num)
        {
            Console.WriteLine($"The number {num} is Even: {num % 2 == 0}");
            return num % 2 == 0;
        }
        public static bool Odd(int num)
        {
            Console.WriteLine($"The number {num} is Odd: {num % 2 != 0}");
            return num % 2 != 0;
        }

        public static bool SimpleNum(int num)
        {
            int j = 0;
            for (int i = 2; i*i<=num && j!=1; i++) 
                if (num % i == 0)
                    j = 1;
            if (j == 1) 
                return false;
            else 
                return true;
        }

        public static bool FibonachiNum(int num)
        {
            if (num == 0 || num == 1 || num == 2) 
                return true;
            else 
                return num == (num - 1) + (num - 2);
        }
        static void Main(string[] args)
        {
            CheckNum<int> checknum = Even;
            Console.WriteLine("Enter an integer number:");
            int number = Int32.Parse(Console.ReadLine());
            checknum += Odd;
            checknum(number);
            checknum = SimpleNum;
            Console.WriteLine($"The number {number} is Simple: {checknum(number)}");
            checknum = FibonachiNum;
            Console.WriteLine($"The number {number} is Fibonachi number: {checknum(number)}");
        }
    }
}
