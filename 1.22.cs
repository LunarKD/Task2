using System;

namespace _1._22
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
                    Console.WriteLine("Введите число x:");
                    double x = checkInput();
                    double y = 7 * Math.Pow(x,2) - 3 * x+ 6;
                    Console.WriteLine($"y = {y}");
                    break;

                case 'б':
                    Console.WriteLine("Введите число a:");
                    double a = checkInput();
                    double x2 = 12 * Math.Pow(a, 2) + 7 * a - 16;
                    Console.WriteLine($"x = {x2}");
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
