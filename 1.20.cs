using System;

namespace _1._20
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
                    double s = 14;
                    double k = -3;
                    double d = s + 1;
                    s = d;
                    k = 2 * s;
                    Console.WriteLine($"s = {s}, k = {k}");
                    break;

                case 'б':
                    double s2 = 0;
                    double k2 = 30;
                    double d2 = k2 - 5;
                    k2 = 2 * d2;
                    s2 = k2 - 100;
                    Console.WriteLine($"s = {s2}, k = {k2}");
                    break;
            }
        }

    }
}
