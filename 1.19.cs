using System;

namespace _1._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирите сценарий выполнения а, б, в или г");
            char inputScen = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (inputScen)
            {
                case 'а':
                    double x = 10;
                    x = -10;
                    Console.WriteLine($"{x}");
                    break;

                case 'б':
                    double x2 = 17.5;
                    x2 = -2*x2;
                    Console.WriteLine($"{x2}");
                    break;

                case 'в':
                    double x3 = 60;
                    x3 = x3-1;
                    x3 = 0;
                    Console.WriteLine($"{x3}");
                    break;
                case 'г':
                    Console.WriteLine("Введите число k");
                    double k = checkInput();
                    double x4 = -50;
                    x4 = -25;
                    x4 = x4 + k;
                    Console.WriteLine($"{x4}");
                    break;
            }
        }

        static public double checkInput()
        {
            double x;
            string KeayboardInput = Console.ReadLine();
            while (!Double.TryParse(KeayboardInput, out x))
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            Console.Clear();
            return x;
        }
    }
}
