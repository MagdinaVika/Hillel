using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Method(int a)
        {
            a--;
            if (a < 10);
            //for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a);
                Method(a);
            }
           
        }
        static void Main(string[] args)
        {
            Method(0);
            //stopwatch.Stop();
            //int i = 1;
            //while (i <= 10)
            //{
            //    int j = 1;
            //    while (j <= 10)
            //    {
            //        Console.Write($"{i*j}\t");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            //char ch = 'd';
            //char ch2 = '5';
            //Console.WriteLine(Char.IsLetter(ch));
            //Console.WriteLine(Char.IsDigit(ch2));
            //Console.ReadLine();


        }
    } 
}
