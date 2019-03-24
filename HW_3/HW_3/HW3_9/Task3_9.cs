using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_9
{
    class Task3_9
    {
        static void Main(string[] args)
        {
            //9.Вычислить значение логического выражения при следующих значениях логических 
            // величин X, Y и Z: X = Ложь, Y = Ложь, Z = Истина: а) X или Y и не Z; г) X и не Y или Z; 
            // б) не X и не Y; д) X и (не Y или Z); в) не (X и Z) или Y; е) X или (не (Y или Z)).
            bool x = false;
            bool y = false;
            bool z = true;

            bool a = x || y && !z;
            bool g = x && !y || z;
            bool b = !x && !y;
            bool d = x && (!y || z);
            bool c = !(x && z) || y;
            bool e = x || (!(y || z));

            Console.WriteLine("Дано:");
            Console.WriteLine("X = " + x + "\t" + "Y = " + y + "\t" + "Z = " + z + "\t");
            Console.WriteLine("=======================================================");
            Console.WriteLine("a) X или Y и не Z:\t\t" + a);
            Console.WriteLine("г) X и не Y или Z:\t\t" + g);
            Console.WriteLine("б) не X и не Y:\t\t\t" + b);
            Console.WriteLine("д) X и (не Y или Z):\t\t" + d);
            Console.WriteLine("в) не (X и Z) или Y:\t\t" + b);
            Console.WriteLine("е) X или (не (Y или Z)):\t" + e);
            Console.ReadKey();

        }
    }
}
