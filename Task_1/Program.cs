using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 1
//Створіть додаток, який відображає текстове повідом-
//лення. Використовуйте механізми делегатів. Делегат має
//повертати void та приймати один параметр типу string
//(текст повідомлення). Для тестування додатка створіть
//різні методи виклику через делегат.
namespace Task_1
{
    public delegate void TextMessage(string text);
    internal class Program
    {
        public static void GetMessage(string text)
        {
            Console.WriteLine(text); 
        }

        public static void GetMessage2(string text)
        {
            Console.WriteLine($"{text} ++ 2");
        }
        static void Main(string[] args)
        {
            TextMessage message = new TextMessage(GetMessage);
            message("Hello World!");
            message = GetMessage2;
            message("Hello World!");
        }
    }
}
