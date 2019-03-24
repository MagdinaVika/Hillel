using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    class Program
    {
        static void Main(string[] args)
        //Ввести с клавиатуры число в диапазоне от 100 до 100 000 000 (введенное число проверяется). 
        //Подсчитать количество четных и нечетных цифр в этом числе в процентном отношении. 
        {
            Console.WriteLine("Введите число в диапазоне от 100 до 100 000 000: ");
            int number = 0;
            try
            {
                int.TryParse(Console.ReadLine(), out number);
                if (number >= 100 && number <= 100000000)
                {
                    double even = 0, odd = 0;
                    string s = number.ToString();
                    int length = s.Length;
                    for (int i = 0; i < length; i++)
                    {
                        int t = 0; t = Convert.ToInt32(s[i]);
                        if (t % 2 == 0) even += 1;
                        else odd += 1;

                    }
                    double evenPers = (even / length) * 100;
                    double oddPers = (odd / length) * 100;

                    //Console.WriteLine("even = " + even + " odd = " + odd);
                    Console.Write("Четных цифр в числе: \t{0:F2}", evenPers); Console.WriteLine("%");
                    Console.Write("Нечетных цифр в числе: \t{0:F2}", oddPers); Console.WriteLine("%");

                }
                else
                {
                    Exception ex = new Exception();
                    throw ex;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели неверное число!");
            }
            Console.ReadKey();
        }
    }
}
