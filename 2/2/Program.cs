using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace _2
{
    class Program
    {
        static void Main(string[] args)

        {
            int a = new Random().Next(1, 10);
            Thread.Sleep(1000);
            int b = new Random().Next(1, 10);
            if (a > b)
                Console.WriteLine("a>b");
        }
        else {
             Console.WriteLine("a<b");
        }
    string answer = (a > b) ? "a > b" :(a < b) ?"a < b" : "a==b"; 

    //string answer = Console.ReadLine(); //ru|| en||ch
    //switch(answer)
    //{
    //    case "ru":
    //        {
    //            Console.WriteLine("Hi");
    //            break;
    //        }
    //    case "en":
    //        {
    //            Console.WriteLine("nehau");
    //            break;
    //        }
    //    case "ch":
    //        {
    //            Console.WriteLine("nehau");
    //            break;
    //        }

    //    default:
    //        Console.WriteLine("enter correct language");
    //        break;
    //}
    //Console.ReadLine();

    //{
    //    int a = new Random().Next(1, 10);
    //    Tread.Sleep(1000);
    //    int b = new Random().Next(1, 10);
    //    if (a > b)
    //    {
    //        Console.WriteLine($"{a}>{b}");

    //    }
    //    else if (a<b)
    //    {
    //        Console.WriteLine("a<b");
    //    }
    //else if (a==b)
    //{
    //Console.WriteLine("a==b");
    //}
}
    
    

