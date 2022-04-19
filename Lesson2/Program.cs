//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс, представляющий учебный класс ClassRoom.
//Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void
//Write(), void Relax().
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса
//Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать,
//писать, отдыхать.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pupil p1=new BadPupil();
            Pupil p2 = new ExcelentPupil();
            
            ClassRoom group=new ClassRoom(p1,p2);

            group.Study();
            Console.WriteLine("-",30);
            group.Read();
            Console.WriteLine("-", 30);
            group.Write();
            Console.WriteLine("-", 30);
            group.Relax();
            Console.WriteLine("-", 30);

            Console.ReadKey();
        }
    }
}
