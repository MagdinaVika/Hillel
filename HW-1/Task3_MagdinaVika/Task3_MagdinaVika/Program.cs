using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_MagdinaVika
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние в сантиметрах:");
            float i = float.Parse(Console.ReadLine());
            Console.Write("Полных метров в нем: ");
            Console.WriteLine(i / 100);
            Console.ReadKey();

        }
    }
}
