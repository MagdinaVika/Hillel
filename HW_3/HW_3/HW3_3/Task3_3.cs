using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_3
{
    class Task3_3
    {
        //3. Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым. 
        static void Main(string[] args)
        {
            int input = 0;
            Console.WriteLine("Введите шестизначный номер трамвайного билета: ");
            try
            {
                string s = Console.ReadLine();
                if (s.Length != 6)
                {
                    Exception ex = new Exception();
                    throw ex;
                }
                else {
                    input = int.Parse(s);

                    int left, right = 0;

                    int i1 = input / 100000;
                    int i2 = input / 10000 % 10;
                    int i3 = input / 1000 % 10;
                    int i4 = input / 100 % 10;
                    int i5 = input / 10 % 10;
                    int i6 = input / 1 % 10;
                    
                    left = i1 + i2 + i3;
                    right = i4 + i5 + i6;

                    //Console.WriteLine("num1: " + i1);
                    //Console.WriteLine("num2: " + i2);
                    //Console.WriteLine("num3: " + i3);
                    //Console.WriteLine("num4: " + i4);
                    //Console.WriteLine("num5: " + i5);
                    //Console.WriteLine("num6: " + i6);

                    if (left == right)
                    {
                        Console.WriteLine("Поздравляем! У Вас счастливый билет!");
                    }
                    else { Console.WriteLine("УПС! У Вас НЕсчастливый билет!");  }
                    
                }
            }
            catch (Exception) {
                Console.WriteLine("Неверный ввод!");
            }
            Console.ReadKey();
        }
    }
}
 