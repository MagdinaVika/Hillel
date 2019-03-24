using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        

        static void Task1_Swap (ref int A, ref int B, ref int C)
        {
            int temp;
            temp = A;
            A = C;
            C = B;
            B = temp;
        }

        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            int z = 6;
            Console.WriteLine($"XYZ = {x} - {y} - {z}" );
            Swap(ref x, ref y, ref z);
            Console.WriteLine($"XYZ = {x} - {y} - {z}");
            Console.ReadKey();
        }
    }
}
