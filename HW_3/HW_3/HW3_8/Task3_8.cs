using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_8
{
    class Task3_8
    {
        //8. Вычислить значение логического выражения при следующих значениях логических 
        //величин X, Y и Z: X = Ложь, Y = Истина, Z = Ложь: а) X или Z; б) X и Y; в) X и Z.

        static void Main(string[] args)
        {
            bool x = false;
            bool y = true;
            bool z = false;

            bool a = x || z;
            bool b = x && y;
            bool c = x && z;

            Console.WriteLine("Дано:");
            Console.WriteLine ("X = " + x + "\t" + "Y = " + y + "\t" + "Z = " + z + "\t");
            Console.WriteLine("a) X OR Z : " + a);
            Console.WriteLine("b) X AND Y : " + b);
            Console.WriteLine("c) X AND Z : " + c);
            Console.ReadKey();
        }
    }
}
