using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonAdvanced
{
    class Printer
    {
        protected ConsoleColor color;
        public Printer(ConsoleColor color)
        {
            this.color = color;
        }
        public virtual void Print(string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ForegroundColor= ConsoleColor.Gray;
        }
    }
    class ColorPrinter : Printer
    {
        public ColorPrinter(ConsoleColor color)
            : base(color)
        {

        }
    }
}
