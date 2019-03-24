using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        public static void Main(string[] args)
        //Ввести три числа и выведите на экран значение суммы и произведения этих чисел.
        {
            float first = 0, second = 0, third = 0, resultSum = 0, resultMult = 0;
            Console.WriteLine("Введите первое число:");
            Single.TryParse(Console.ReadLine(), out first);
            Console.WriteLine("Введите второе число:");
            Single.TryParse(Console.ReadLine(), out second);
            Console.WriteLine("Введите третие число:");
            Single.TryParse(Console.ReadLine(), out third);

            resultSum = first + second + third;
            Console.WriteLine("Сумма введенных чисел =  " + resultSum);

            resultMult = first * second * third;
            Console.WriteLine("Произведение введенных чисел =  " + resultMult);
            Console.Read();
        }
    }
}
