using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_6
{
    class Program
    {
        static void Main(string[] args)
    //    Дано двузначное число.Найти: 
    //    а) число десятков в нем;
    //    б) число единиц в нем;
    //    в) сумму его цифр; 
    //    г) произведение его цифр.

        {
            Console.WriteLine("Введите двузначное число: ");
            try
            {
                int i = 0; string s = Console.ReadLine();
                Exception ex1 = new Exception();
                if (s.Length != 2) throw ex1;
                i = Convert.ToInt32(s);

                int a = i / 10;
                int b = i % 10;
                int c = a + b;
                int d = a * b;
                Console.WriteLine("число десятков в нем: \t" + a);
                Console.WriteLine("число eдиниц в нем: \t" + b); // число единиц возможно равно числу введенному. к примеру ввели 20, единиц тоже 20 ?!
                Console.WriteLine("сумма его цифр: \t" + c);
                Console.WriteLine("произведение его цифр: \t" + d);
            }
            catch (Exception)
            {
                Console.WriteLine("Неверный ввод!");
            }
            
            Console.ReadKey();
        }
    }
}
