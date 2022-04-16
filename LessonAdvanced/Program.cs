//Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создайте класс Printer.
//В теле класса создайте метод void Print(string value), который выводит на экран значение
//аргумента.
//Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
//соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
//выводились разными цветами.
//Обязательно используйте приведение типов.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColorPrinter color = new ColorPrinter(ConsoleColor.DarkGreen);
            color.Print("Green");

            Printer printUp = color;
            printUp.Print("Green");

            ColorPrinter color1 = new ColorPrinter(ConsoleColor.Red);
            color1.Print("Red");

            Console.ReadKey();
        }
    }
}
