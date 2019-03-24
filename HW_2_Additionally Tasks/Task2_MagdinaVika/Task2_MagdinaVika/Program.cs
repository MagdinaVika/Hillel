using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_MagdinaVika
{
    class Program
        //Составить программу вывода на экран числа, вводимого с клавиатуры.Выводимому числу должно предшествовать сообщение "Вы ввели число".​
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            float i = float.Parse(Console.ReadLine());
            Console.Write("Вы ввели число: "+i);
            Console.ReadKey();

        }
    }
}
