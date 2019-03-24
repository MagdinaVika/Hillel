using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_4
{
    class Program
    {
        static void Main(string[] args)
            //Дано трехзначное число. Найти число, полученное при прочтении его цифр справа налево.
        {
            Console.WriteLine ("Введите трехзначное число: ");
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

                Console.Write("Ваше число прочитаное наоборот - " + third.ToString() + second.ToString() + first.ToString());

            }
            catch (Exception) {
                Console.WriteLine("Неверный ввод!");
            }
            Console.ReadKey();
        }
    }
}
