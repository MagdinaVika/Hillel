using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
//        1. Заполнить массив из восьми элементов следующими значениями: первый элемент массива равен 37, второй — 0, третий — 50, четвертый — 46, пятый — 34, шестой — 46, седьмой — 0, восьмой —13. Вывести на экран.
//2. Массив предназначен для хранения значений ростов двенадцати человек.С помощью случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 163 до 190 включительно.
//3. Присвоить начальные целые значения 1, 2, 3,… ,10 элементам массива из десяти элементов и выводит на экран элементы массива с 
//четным индексом.
//4. Создать массив размерностью в 10 элементов, вывести на экран все элементы массива в обратном порядке.
//5. Создать массив размерностью в 12 элементов, суммировать значения. Суммирование осуществляется в теле цикла for. Значения, используемые 
//в качестве начальных для массива A, вводятся в программу пользователем с клавиатуры.
//6. В массиве хранится информация о сопротивлении каждого из 20 элементов электрической цепи.Все элементы соединены параллельно. 
//Определить общее сопротивление цепи. (1 / R(1) + 1 / R(2)… 1 / R(n))
//7. Выяснить, верно ли, что сумма элементов массива есть неотрицательное число.
//8. Дан массив. Поменять местами: а) второй и пятый элементы; б) m-й и n-й элементы;

    {
        static void Main(string[] args)
        {
            //int[] arr = { 37, 0, 50, 46, 34, 46, 0, 13 };1 2 3 4 = 34 12
            //int[] arr1 = new int[12];
            ////arr1[0] = 160;
            //    Random random = new Random();
            //for (int i = 0; i < arr1.Length; i++)//заполняет массив рандомными числами
            //{
            //    arr1[i] = random.Next(163, 190);
            //}

            //for (int i = 0; i < arr1.Length; i++)//выводит на консиль элементы массива
            //{
            //    Console.Write(arr1[i] + ", ");
            //}

            //ray();
            //ray1();
            //Console.WriteLine(ray6());
            Console.WriteLine(ray7());
            ray8();
            

            Console.ReadKey();

        }

        private static void ray8()
        {
            int[] arr = { 1, 2, 3, 4, 5,6,7,8 };
            Printarray(arr);
            int temp = 0;
            for (int i = 0; i < arr.Length/2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length/2+i];
                arr[4] = temp;
                
            }
            Printarray(arr); 

        }
        private static void Printarray(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }
        private static bool ray7()
        {
            int[] arr = { -1, 2, 3, 4, -5, -8, -6 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i]; 
            }
            return sum > 0 ; //он сам определит тру или фолс
        }

        private static double ray6()
        {
            double[] arr = new double[20];
            Random random = new Random(); 

            for (int i = 0; i < arr.Length; i++)
                //заполняет массив рандомными числами
            {
                arr[i] = random.Next(163, 190);
            }
            double sum = 0; 
            for (int i = 0; i < arr.Length; i++)
            {
                sum += 1 / arr[i];// sum = sum + 1/arr[i]
            }

            return sum; 
        }

        private static void ray1()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < arr.Length/2; i++)
            {
                int temp = arr[i];//arr.length = 10
                arr[i] = arr[arr.Length - 1-i];//показывает 10 элементов
                arr[arr.Length - 1-i] = temp;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " , ");
            }
        }

        private static void ray()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)// 0=0+1, 1=1+1...
            {
                arr[i] = i + 1; 
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i%2==0) 
                    Console.WriteLine(arr[i]);//выводим элементы массива
            }
        }
    }
}
