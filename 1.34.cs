using System;

namespace _1._34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            var a = checkInput(false);
            Console.WriteLine("Введите число b:");
            var b = checkInput(true);
            double x = -b / a;
            Console.WriteLine($"ax + b = 0, x =  {x}");

        }

        static public double checkInput(bool allowZero)
        {
            double x;
            string KeayboardInput = Console.ReadLine();
            while (!Double.TryParse(KeayboardInput, out x) || (!allowZero && x == 0))
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            Console.Clear();
            return x;
        }
    }
}
