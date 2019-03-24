using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // string result="";
            //result= method("Hello");
            //result += method("Hi");
            // result += method("Hey");
            Task1("Привет", "пока", "чао");
            Console.ReadKey();
        }

        static string method(string str)
        {
            return "("+str + ")";

            
        }
        //1. Даны переменные A, B, C. Изменить их значения, переместив содержимое A в B, B — в C, C — в A, 
        //и вывести новые значения переменных A, B, C.
        static void Task1(string a, string b, string c)
        {
            Console.WriteLine("A=" + a + " " + "B=" + b + " " + "C=" + c);
            string temp = a;
            a = c;
            c = b;
            b = temp;
            Console.WriteLine("A="+a+" "+"B="+b+" "+"C="+c);

        }
    }

}
