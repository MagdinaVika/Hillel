using System;

class Program
{
    public static void Main()
    {
        string str = "Hello from Application!";
        string str2 = "Hi", str3 = "Hey";
        string answer = str + str2 + str3; // Конкатенация 

        int i = 9; // целое число
        int y = i + 789 * (123 / 456);

        double d = 1231 / 456.0; // вещественное число

        bool b = i > d;// булевое число


        Console.WriteLine(i);
        Console.WriteLine(d);
        Console.WriteLine(b);
        Console.WriteLine(str2);
        Console.WriteLine(str);
        Console.WriteLine(str3);
        Console.WriteLine(answer);
        Console.WriteLine("Hello from Another!");

        Console.ReadLine();
    }

}
