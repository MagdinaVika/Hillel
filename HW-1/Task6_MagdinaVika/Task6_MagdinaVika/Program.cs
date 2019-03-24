using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_MagdinaVika
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine ("Введите число:");
        double i = double.Parse(Console.ReadLine());
            double result = i * i;
            Console.WriteLine("Квадрат введенного числа = " +result);
            Console.ReadKey();

    }
    }
}
