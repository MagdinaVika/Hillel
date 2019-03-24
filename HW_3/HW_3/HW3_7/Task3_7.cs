using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_7
{
    class Program
    {
        static void Main(string[] args)
   //    Дано трехзначное число.Найти: 
   //    а) число единиц в нем;
   //    б) число десятков в нем;
   //    в) сумму его цифр; 
   //    г) произведение его цифр.

        {
            Console.WriteLine("Введите трехзначное число: ");
            try
            {
                int i = 0; string s = Console.ReadLine();
                Exception ex1 = new Exception();
                if (s.Length != 3) throw ex1;
                i = Convert.ToInt32(s);

                int a = i % 10;
                int b = i / 10 % 10;
                int c = i / 100;
                Console.WriteLine("num1: " + a);
                Console.WriteLine("num2: " + b);
                Console.WriteLine("num3: " + c);

                int y = i / 10;
                int x = a + b + c;
                int z = a * b * c;
                Console.WriteLine("число eдиниц в нем: \t" + a);
                Console.WriteLine("число десятков в нем: \t" + y); 
                Console.WriteLine("сумма его цифр: \t" + x);
                Console.WriteLine("произведение его цифр: \t" + z);
            }
            catch (Exception)
            {
                Console.WriteLine("Неверный ввод!");
            }

            Console.ReadKey();

        }


    }
}
