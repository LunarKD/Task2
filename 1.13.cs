using System;

namespace _1._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирите сценарий выполнения a, b или c");
            char inputScen = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (inputScen)
            {
                case 'a':
                    Console.WriteLine($"2кг");
                    Console.WriteLine($"13 17");
                    break;

                case 'b':
                    Console.WriteLine("Введите число a");
                    int a = checkInput();
                    Console.WriteLine("Введите число b");
                    int b = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{a} 1");
                    Console.WriteLine($"19 {b}");
                    break;

                case 'c':
                    Console.WriteLine("Введите число x");
                    int x = checkInput();
                    Console.WriteLine("Введите число y");
                    int y = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{x} {y}");
                    Console.WriteLine($"5 {y}");
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
