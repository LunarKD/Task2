using System;

namespace _1._31
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
                    Console.WriteLine("Введите число a:");
                    double a = checkInput();
                    Console.WriteLine("Введите число b:");
                    double b = checkInput();
                    double ar = (a + b) / 2.0;
                    Console.WriteLine($"Cреднее арифметическое = {ar}");
                    break;

                case 'б':
                    Console.WriteLine("Введите число a:");
                    double a2 = checkInput();
                    Console.WriteLine("Введите число b:");
                    double b2 = checkInput();
                    double geo = Math.Sqrt(a2 * b2);
                    Console.WriteLine($"Cреднее геометрическое = {geo}");
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
