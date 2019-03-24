using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_MagdinaVika
{
    class Program
    {
        static void Main(string[] args) 
        //Дан прямоугольник с размерами 543 x 130 мм.Сколько квадратов со стороной 130 мм можно отрезать от него?
        {
            const int length = 543;
            const int width = 130;
            int count_of_squares = length / width;
            Console.WriteLine("Дан прямоугольник с размерами 543 x 130 мм.Сколько квадратов со стороной 130 мм можно отрезать от него ?");
            Console.WriteLine("Answer: " + count_of_squares);
            Console.ReadKey(); 


        }
    }
}
