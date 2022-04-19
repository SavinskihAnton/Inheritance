using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Vehicle
    {
        readonly int xLocation;
        public int XLocation { get { return xLocation; } }

        readonly int yLocation;
        public int YLocation { get { return yLocation; } }

        readonly uint price;
        public uint Price { get { return price; } }

        readonly uint speed;
        public uint Speed { get { return speed; } }

        readonly int year;
        public int Year { get { return year; } }

        public Vehicle(int xLocation, int yLocation, uint price, uint speed, int year)
        { 
            this.xLocation = xLocation;
            this.yLocation = yLocation;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        public Vehicle(uint price, uint speed, int year)
            : this(0, 0, price, speed, year)
        { 
        
        }
    }
    class Car : Vehicle
    {
        public Car(int xLocation, int yLocation, uint price, uint speed, int year)
            : base(xLocation, yLocation, price, speed, year)
        {

        }
        public Car(uint price, uint speed, int year)
            : base(price, speed, year)
        {

        }
    }
    class Ship : Vehicle
    {
        public Ship(int xLocation, int yLocation, uint price, uint speed, int year)
            : base(xLocation, yLocation, price, speed, year)
        {

        }
        public Ship(uint price, uint speed, int year)
            : base(price, speed, year)
        {

        }
        int passengers;
        public int Passengers 
        {
            get 
            { 
                return passengers;
            }
            set
            {
                if (passengers < 0)
                {
                    Console.WriteLine("Количество пассажиров не может быть ментше нуля");
                }
            }
        }
        string port;
        public string Port 
        { 
            get
            {
                if (port == null)
                { Console.WriteLine("Порт не задан"); }
                return port;
            }
            set 
            {
                if (value == null)
                {
                    Console.WriteLine("Значение пусто");
                }
                else 
                {
                port = value;
                }
            } 
        }
    }
    class Plain : Vehicle
    {
        public Plain(int xLocation, int yLocation, uint price, uint speed, int year)
            : base(xLocation, yLocation, price, speed, year)
        {

        }
        public Plain(uint price, uint speed, int year)
            : base(price, speed, year)
        {

        }
        public int Hight { get; set; }
        int passengers;
        public int Passengers
        {
            get
            {
                return passengers;
            }
            set
            {
                if (passengers < 0)
                {
                    Console.WriteLine("Количество пассажиров не может быть ментше нуля");
                }
            }
        }
    }
}
