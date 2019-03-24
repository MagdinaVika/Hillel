using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_MagdinaVika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            float i1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            float i2 = float.Parse(Console.ReadLine());
            float i3 = (i1 + i2) / 2;
            Console.WriteLine("Среднее введенный чисел = " + i3) ;
            Console.ReadKey();
        }
    }
}
