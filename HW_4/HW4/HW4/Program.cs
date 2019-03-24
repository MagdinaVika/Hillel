using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int A = 1;
            //int B = 2;
            //int C = 3;
            //int AA = 32;
            //Console.WriteLine("Task 1: ");
            //Console.WriteLine($"До вызова метода:\tA = {A}, B = {B}, C = {C}");
            //Task1(ref A, ref B, ref C);
            //Console.WriteLine($"После вызова метода:\tA = {A}, B = {B}, C = {C}");
            //Line();
            //Console.WriteLine($"Task 2:\nЧисло = {AA}");
            //Task2(AA);
            //Line();
            //Console.WriteLine("Task 3: ");
            //Task3();
            //Line();
            //Console.WriteLine("Task 4: ");
            //Task4();
            //Line();
            //Console.WriteLine("Task 4_1: ");
            //Task4_1();
            //Line();
            //Console.WriteLine("Task 5: ");
            //int test = 1; int test2 = -1; int test3 = 0;
            //Console.WriteLine($"First num = {test}\t Second num = {test2}\t Third num = {test3}");
            //Task5(ref test); Task5(ref test2); Task5(ref test3);
            //Console.WriteLine($"First num = {test}\t Second num = {test2}\t Third num = {test3}");
            //Line();
            //Console.WriteLine("Task 6: ");
            //test = -1; test2 = 10; test3 = 1;
            //Console.WriteLine($"First num = {test}\t Second num = {test2}\t Third num = {test3}");
            //int countPositive = Task6(test, test2, test3);
            //Console.WriteLine($"Количество положительных чисел: {countPositive}");
            //Line();
            //Console.WriteLine("Task 7: ");
            //test = -1; test2 = 10; test3 = 1;
            //Console.WriteLine($"First num = {test}\t Second num = {test2}\t Third num = {test3}");
            //Task7(test, test2, test3);
            //Line();
            //Console.WriteLine("Task 8: ");
            //test = -1; test2 = 10;
            //Console.WriteLine($"До вызова метода:\tA = {A}, B = {B}");
            //Task8(ref A, ref B);
            //Console.WriteLine($"После вызова метода:\tA = {A}, B = {B}");
            //Line();
            //Console.WriteLine("Task 9: ");
            //int num1 = 59;
            //Console.WriteLine($"Число {num1} чётное? - Ответ: " + Task9(num1));
            //Line();
            //Console.WriteLine("Task 10: ");
            //A = 1; double D = 342.5;
            //Console.WriteLine($"Вы ввели {D} {Task10_a(A)}, в метрах это равно {Task10(A, D)}");
            //Line();
            //Console.WriteLine("Task 11: ");
            //char ch = 'С'; int go = -1;
            //Console.WriteLine($"Робот: Вы ввели направление {Task11_a(ch)} и хотите идти {Task11_b(go)}. Вы пойдёте на {Task11_a(Task11(ch, go))}.");
            //Line();
            //Console.WriteLine("Task 12: ");
            //int age = 51;
            //Console.WriteLine($"Ваш возраст {age} - {Task12(age)}");
            //Line();
            //Console.WriteLine("Task 14: ");
            //double DA = 2.5; double DB = 1.5; double DC = 3.5;
            //Console.WriteLine($"First num = {A}\t Second num = {B}\t Third num = {C}");
            //double res = Task14(A, B, C);
            //Console.WriteLine($"Среднее трёх чисел = {res} ");
            //Line();
            //Console.WriteLine("Task 15: ");
            //int t = 12; int r = 3;
            //Console.WriteLine($"число {r} является делителем число {t} ");
            //bool res1 = Task15(t, r);
            ////Console.WriteLine(res);
            //Line();
            //Console.WriteLine("Task 16: ");
            //Console.WriteLine("принадлежит ли число введенное с клавиатуры, интервалу (-5;3) ?");
            //Console.WriteLine(Task16());
            //Line();
            Console.WriteLine("Task 17: ");
            int i = 34;
            Console.WriteLine(Task17(i));
            Console.WriteLine($"число 3 входит в число {i}");
            //Line();
            //Console.WriteLine("Task 18: ");
            //Console.WriteLine("Сумма положительных нечетных чисел, меньших 50 равна ");
            //Console.WriteLine(Task18());
            //Line();
            //Console.WriteLine("Task 19: ");
            //int numA = 10;
            //int numB = 20;
            //Console.WriteLine($"Найти сумму целых положительных чисел из промежутка от a = {numA} до b ={numB}, кратных четырем");
            //Console.WriteLine(Task19(numA, numB));
            Console.ReadLine();
            Console.ReadKey();
        }

        static void Line()
        {
            Console.WriteLine(new string('=', 60));
        }

        static void Task1(ref int A, ref int B, ref int C)
        {
            int temp;
            temp = A;
            A = C;
            C = B;
            B = temp;
        }
        static void Task2(int number)
        {
            //Console.WriteLine("Введите двузначное число: ");
            try
            {
                if (number <= 99 && number >= -99)
                {

                }
                else
                {
                    Exception exception = new Exception();
                    throw exception;
                }

                int a = number / 10;
                int b = number % 10;
                Console.WriteLine("Десятков в нем:\t" + a);
                Console.WriteLine("Единиц в нем:\t" + b);
            }
            catch (Exception)
            {
                Console.WriteLine("Неверный ввод!");
            }

        }
        static void Task3()
        {
            int i = 11;
            int a = i / 5;
            Console.WriteLine($"i = 11\ni / 5 = {a}");


        }
        static void Task4()
        {
            //bool b = (double)(1 / 2);
            Console.WriteLine("bool b = (double)(1 / 2); // this line produces compilation error\n" +
                "CS0029  Cannot implicitly convert type 'double' to 'bool'");
        }
        static void Task4_1()
        {
            Console.WriteLine(
            "Возраст человека  - uint  \n" +
            "Население города  - uint  \n" +
            "Число звезд в галактике - ulong  \n" +
            "Один байт ОЗУ - byte  \n" +
            "Средняя зарплата за год - double  \n" +
            "Сведения спортсмен или нет - bool  \n" +
            "Цвет фигуры - enum Color  \n" +
            "Длина в мм.  - ushort  \n" +
            "Длина в см.  - ushort  \n" +
            "Фамилия человека - string  \n" +
            "Время года    - enum Seasons  \n" +
            "Пол человека  - char "
            );
        }
        static int Task5(ref int num)
        {
            if (num == 0)
            {
                num = 10;
            }
            else if (num < 0)
            {
                num -= 2;
            }
            else
            {
                num += 1;
            }
            return num;

        }
        static int Task6(int A, int B, int C)
        {
            int counter = 0;
            if (A > 0) counter++;
            if (B > 0) counter++;
            if (C > 0) counter++;

            return counter;

        }
        static void Task7(int A, int B, int C)
        {
            int positives = 0, negatives = 0;
            if (A > 0) positives++; else if (A < 0) negatives++;
            if (B > 0) positives++; else if (A < 0) negatives++;
            if (C > 0) positives++; else if (A < 0) negatives++;
            Console.WriteLine($"Кол-во положительных чисел: {positives}\nКол-во отрицательных чисел: {negatives}");

        }
        static void Task8(ref int A, ref int B)
        {
            if (A == B)
            {
                A = 0; B = 0;
            }
            else
            {
                A = A + B;
                B = A;
            }


        }
        static bool Task9(int num)
        {
            return (num % 2 == 0);
        }
        static double Task10(int unit, double lenght)
        {
            double result = 0;
            switch (unit)
            {
                case 1: //дециметр
                    result = lenght / 10;
                    break;
                case 2: //километр
                    result = lenght * 1000;
                    break;
                case 3: //метр
                    result = lenght;
                    break;
                case 4: //миллиметр
                    result = lenght / 1000;
                    break;
                case 5: //сантиметр
                    result = lenght / 100;
                    break;

            }

            return result;
        }
        static string Task10_a(int A)
        {
            string unit = "";
            switch (A)
            {
                case 1:
                    unit = "дециметров";
                    break;
                case 2:
                    unit = "километров";
                    break;
                case 3:
                    unit = "метров";
                    break;
                case 4:
                    unit = "миллиметров";
                    break;
                case 5:
                    unit = "сантиметров";
                    break;
            }
            return unit;

        }
        static char Task11(char direction, int command)
        {
            if (command == 0) return direction;
            if (command == 1)
            {
                switch (direction)
                {
                    case 'С':
                        direction = 'З';
                        break;
                    case 'З':
                        direction = 'Ю';
                        break;
                    case 'Ю':
                        direction = 'В';
                        break;
                    case 'В':
                        direction = 'С';
                        break;
                }
            }
            if (command == -1)
            {
                switch (direction)
                {
                    case 'С':
                        direction = 'В';
                        break;
                    case 'З':
                        direction = 'С';
                        break;
                    case 'Ю':
                        direction = 'З';
                        break;
                    case 'В':
                        direction = 'Ю';
                        break;
                }
            }
            return direction;
        }
        static string Task11_a(char C)
        {

            string direction = "";
            switch (C)
            {
                case 'С':
                    direction = "Север";
                    break;
                case 'З':
                    direction = "Запад";
                    break;
                case 'Ю':
                    direction = "Юг";
                    break;
                case 'В':
                    direction = "Восток";
                    break;
            }
            return direction;
        }
        static string Task11_b(int C)
        {

            string direction = "";
            switch (C)
            {
                case 1:
                    direction = "налево";
                    break;
                case -1:
                    direction = "направо";
                    break;
                case 0:
                    direction = "прямо";
                    break;
            }
            return direction;


        }
        static string Task12(int num)
        {
            try
            {
                if (num > 69 || num < 20) { throw new Exception(); }
            }
            catch (Exception) { Console.WriteLine("Неправильный возраст!"); }

            int desyatki = num / 10, edinicy = num % 10;
            //Console.WriteLine($"num = {num}, desyatki = {desyatki}, edinicy = {edinicy}");
            string age = "";
            switch (desyatki)
            {
                case 2:
                    age = "двадцать";
                    break;
                case 3:
                    age = "тридцать";
                    break;
                case 4:
                    age = "сорок";
                    break;
                case 5:
                    age = "пятьдесят";
                    break;
                case 6:
                    age = "шестьдесят";
                    break;
            }
            switch (edinicy)
            {
                case 1:
                    age = age + " один год";
                    break;
                case 2:
                    age = age + " два года";
                    break;
                case 3:
                    age = age + " три года";
                    break;
                case 4:
                    age = age + " четыре года";
                    break;
                case 5:
                    age = age + " пять лет";
                    break;
                case 6:
                    age = age + " шесть лет";
                    break;
                case 7:
                    age = age + " семь лет";
                    break;
                case 8:
                    age = age + " восемь лет";
                    break;
                case 9:
                    age = age + " девять лет";
                    break;
                case 0:
                    age = age + " лет";
                    break;
            }
            return age;
        }
        static void Task13()
        {
            //13. Угадать число, которое загадал пользователь, используя только инструкцию if-else
        }
        static double Task14(double A, double B, double C)
        {


            if (A == B || A == C || B == C)
            {
                Console.WriteLine("Ошибка!");
                return -1;
            }
            double average = 0;
            double sum = A + B + C;
            average = sum / 3 + sum % 3;
            return average;
        }
        static bool Task15(double arg1, double arg2)
        {

            return (arg1 % arg2 == 0);
        }
        static bool Task16()
        {
            int newnum = 0;

            try
            {
                Console.WriteLine("Enter a number: ");
                string a = Console.ReadLine();
                Int32.TryParse(a, out newnum);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error!");
            }
            return (newnum >= -5 && newnum <= 3); //Проверить, принадлежит ли число введенное с клавиатуры, интервалу (-5;3). 
            //ком.строка

        }



        static bool Task17(int b)
 
        {
            int a = 3;
            if (b<10 && b> -10 || b>99 || b< -99) {
                return false;
            }
            int c = 0;
            int d = 0;
            c = b / 10;
            d = b % 10; 
            return (c==a || d==a);
        }
         static int Task18()
        {
            int summ = 0;
            for (int i = 0; i <= 50; i += 2)
            {
                summ += i;
            }
            return summ; 
        }

         static int Task19(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 4 == 0)
                {
                 sum += i;
                }
            }

            return sum;
                
        }
        
    }
    
}
