using System;

namespace _1._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирите сценарий выполнения а или б");
            char inputScen = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (inputScen)
            {
                case 'а':
                    double a = 5.8;
                    double b = -7.9;
                    b = a;
                    a = b;
                    Console.WriteLine($"a = {a}, b = {b}");
                    break;

                case 'б':
                    double a2 = 0;
                    double b2 = -9.99;
                    b2 = a2;
                    a2 = b2;
                    Console.WriteLine($"a = {a2}, b = {b2}");
                    break;
            }
        }

    }
}
