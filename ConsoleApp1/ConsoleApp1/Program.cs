using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cl = new Class1
            {
                Name = "Hello world"
            };

            Console.WriteLine(cl.Name);
            Console.ReadKey();
        }
    }
}
