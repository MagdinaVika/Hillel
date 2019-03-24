using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program

    {
        public static object FillDouble { get; private set; }

        static void FillArr(int[] arr)
        {
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 1000);
                //Thread.Sleep(TimeSpan.FromMilliseconds(random.Next(0, 1000))); 
            }

        }
        static void Arr(int[] arr, bool isTrue)
        {
            foreach(int item in arr)
                if (arr[i]%4 == 0)
            {
                Console.WriteLine(item + " ");


                    int[,] doubleArr = new int[10, 10];
                    FillDoubleArr(doubleArr); 
            }
        }

        private static void FillDoubleArr(int[,] doubleArr)
        {
            throw new NotImplementedException();
        }

        private static void SomthingPrint (int[,])

            for (int i = 0; i<length; i++)
			{
            if (i==2){
            for (int j =indexer2-1; j>=0; j--){

			{

			}
			}

          

        static void Main(string[] args)
        {
            int[] arr = new int[10];
            FillArr();
            PrintArr(arr, false);

            Console.WriteLine();

            
        }
            
    }
}
