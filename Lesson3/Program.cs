//Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Vehicle.
//В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год
//выпуска).
//Создайте 3 производных класса Plane, Саг и Ship.
//Для класса Plane должна быть определена высота и количество пассажиров.
//Для класса Ship — количество пассажиров и порт приписки.
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(2000, 150, 2012) { Passengers = 1500, Port = "Stambul" };
            Console.WriteLine($"{ship.Port} {ship.Price}");
            Console.ReadKey();
        }
    }
}