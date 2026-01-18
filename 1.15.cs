using System;

namespace _1._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирите сценарий выполнения а, б, в, г, д, е, ж, з, и или к");
            char inputScen = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (inputScen)
            {
                case 'а':
                    Console.WriteLine("Введите число x");
                    int x = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{-1.0 / (Math.Pow(x,2))}");
                    break;

                case 'б':
                    Console.WriteLine("Введите число a");
                    int a = checkInput();
                    Console.WriteLine("Введите число b");
                    int b = checkInput();
                    Console.WriteLine("Введите число c");
                    int c = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{a / (b * c)}");
                    break;

                case 'в':
                    Console.WriteLine("Введите число a");
                    int a2 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b2 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c2 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(a2 / b2) * c2}");
                    break;
                case 'г':
                    Console.WriteLine("Введите число a");
                    int a3 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b3 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(a3 + b3) / 2.0}");
                    break;
                case 'д':
                    Console.WriteLine("Введите число a");
                    int a4 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b4 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{5.45 * ((a4 + 2 * b4) / (2 - a4))}");
                    break;
                case 'е':
                    Console.WriteLine("Введите число a");
                    int a5 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b5 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c3 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(-b5 + Math.Sqrt(Math.Pow(b5,2) - 4 * a5 * c3)) / (2 * a5)}");
                    break;
                case 'ж':
                    Console.WriteLine("Введите число a");
                    int a6 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b6 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c4 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(-b6 + (1.0 / a6)) / (2.0 / c4)}");
                    break;
                case 'з':
                    Console.WriteLine("Введите число a");
                    int a7 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b7 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{1/(1+((a7+b7)/2.0))}");
                    break;
                case 'и':
                    Console.WriteLine($"{1.0 / (1 + 1.0 / (2 + 1.0 / (2 + 3.0 / 5.0)))}");
                    break;
                case 'к':
                    Console.WriteLine("Введите число m");
                    int m = checkInput();
                    Console.WriteLine("Введите число n");
                    int n = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{Math.Pow(2, Math.Pow(m, n))}");
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
