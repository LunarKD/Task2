using System;

namespace _1._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирите сценарий выполнения а, б, в, г, д, е, ж, з, и, к, л или м");
            char inputScen = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (inputScen)
            {
                case 'а':
                    Console.WriteLine("Введите число x");
                    int x = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{2*x}");
                    break;

                case 'б':
                    Console.WriteLine("Введите число x");
                    int x2 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{Math.Sin(x2)}");
                    break;

                case 'в':
                    Console.WriteLine("Введите число a");
                    int a = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{Math.Pow(a,2)}");
                    break;
                case 'г':
                    Console.WriteLine("Введите число x");
                    int x3 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{Math.Sqrt(x3)}");
                    break;
                case 'д':
                    Console.WriteLine("Введите число n");
                    int n = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{Math.Abs(n)}");
                    break;
                case 'е':
                    Console.WriteLine("Введите число y");
                    int y = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{5*Math.Cos(y)}");
                    break;
                case 'ж':
                    Console.WriteLine("Введите число a");
                    int a2 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{-7.5 *Math.Pow(a2,2)}");
                    break;
                case 'з':
                    Console.WriteLine("Введите число x");
                    int x4 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{3*Math.Sqrt(x4)}");
                    break;
                case 'и':
                    Console.WriteLine("Введите число alpha");
                    int alpha = checkInput();
                    Console.WriteLine("Введите число beta");
                    int beta = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{Math.Sin(alpha) * Math.Cos(beta) + Math.Cos(alpha) * Math.Sin(beta)}");
                    break;
                case 'к':
                    Console.WriteLine("Введите число a");
                    int a3 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{a3 * Math.Sqrt(2 * b)}");
                    break;
                case 'л':
                    Console.WriteLine("Введите число alpha");
                    int alpha2 = checkInput();
                    Console.WriteLine("Введите число beta");
                    int beta2 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{3 * Math.Sin(2 * alpha2) * Math.Cos(3 * beta2)}");
                    break;
                case 'м':
                    Console.WriteLine("Введите число x");
                    int x5 = checkInput();
                    Console.WriteLine("Введите число y");
                    int y2 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{-5 * Math.Sqrt(x5 + Math.Sqrt(y2))}");
                    break;
            }
        }

        static public int checkInput()
        {
            int x;
            string KeayboardInput = Console.ReadLine();
            while (!Int32.TryParse(KeayboardInput, out x))
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            Console.Clear();
            return x;
        }
    }
}
