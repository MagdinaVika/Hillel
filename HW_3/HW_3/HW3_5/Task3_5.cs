using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_5
{
    class Task3_5
    {
        //5. Дано трехзначное число. Найти число, полученное при перестановке первой и второй цифр заданного числа.   
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");
            int num = 0;

            try
            {
                string s = Console.ReadLine();
                if (s.Length != 3)
                {
                    Exception ex1 = new Exception(); throw ex1;
                }
                num = Convert.ToInt32(s);
                int first = num / 100;
                int second = num / 10 % 10;
                int third = num / 1 % 10;

                //Console.WriteLine("num1: " + first);
                //Console.WriteLine("num2: " + second);
                //Console.WriteLine("num3: " + third);

                Console.WriteLine("Число, полученное при перестановке первой и второй цифр заданного числа: ");
                Console.WriteLine (second.ToString() + first.ToString() + third.ToString());

            }
            catch (Exception)
            {
                Console.WriteLine("Неверный ввод!");
            }
            Console.ReadKey();
        }
    }
}
