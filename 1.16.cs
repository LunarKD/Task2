using System;

namespace _1._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирите сценарий выполнения а, б, в, г, д, е, ж, з, и, к, л, м, н или о");
            char inputScen = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (inputScen)
            {
                case 'а':
                    Console.WriteLine("Введите число a");
                    int a = checkInput();
                    Console.WriteLine("Введите число b");
                    int b = checkInput();
                    Console.WriteLine("Введите число c");
                    int c = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(a/b)/c}");
                    break;

                case 'б':
                    Console.WriteLine("Введите число a");
                    int a2 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b2 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c2 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(a2 * b2) / c2}");
                    break;

                case 'в':
                    Console.WriteLine("Введите число a");
                    int a3 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b3 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c3 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(a3 / b3) * c3}");
                    break;
                case 'г':
                    Console.WriteLine("Введите число a");
                    int a4 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b4 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c4 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{a4 + (b4 / c4)}");
                    break;
                case 'д':
                    Console.WriteLine("Введите число a");
                    int a5 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b5 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c5 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(a5+b5)/c5}");
                    break;
                case 'е':
                    Console.WriteLine("Введите число a");
                    int a6 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b6 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c6 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{a6+(b6/b6)+c6}");
                    break;
                case 'ж':
                    Console.WriteLine("Введите число a");
                    int a7 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b7 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c7 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(a7+b7)/(b7+c7)}");
                    break;
                case 'з':
                    Console.WriteLine("Введите число a");
                    int a8 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b8 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{a8/Math.Sin(b8)}");
                    break;
                case 'и':
                    Console.WriteLine("Введите число a");
                    int a9 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b9 = checkInput();
                    Console.WriteLine("Введите число x");
                    int x = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(1/2)*a9*b9* Math.Sin(x)}");
                    break;
                case 'к':
                    Console.WriteLine("Введите число a");
                    int a10 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b10 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c10 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(2*b10*c10*Math.Cos(a10/2))/(b10+c10)}");
                    break;
                case 'л':
                    Console.WriteLine("Введите число a");
                    int a11 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b11 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c11 = checkInput();
                    Console.WriteLine("Введите число R");
                    int R = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{4*R*Math.Sin(a11/2)*Math.Sin(b11/2)*Math.Sin(c11/2)}");
                    break;
                case 'м':
                    Console.WriteLine("Введите число a");
                    int a12 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b12 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c12 = checkInput();
                    Console.WriteLine("Введите число x");
                    int x2 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(a12*x2+b12)/(c12*x2+b12)}");
                    break;
                case 'н':
                    Console.WriteLine("Введите число a");
                    int a13 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b13 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(2*Math.Sin((a13+b13)/2))/(2*Math.Cos((a13-b13)/2))}");
                    break;
                case 'о':
                    Console.WriteLine("Введите число x");
                    int x3 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{Math.Abs(2*Math.Sin(-3*Math.Abs(x3/2)))}");
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
