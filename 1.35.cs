using System;

namespace _1._35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый катет:");
            var a = checkInput(false);
            Console.WriteLine("Введите второй катет:");
            var b = checkInput(false);
            double x = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"Гипотенузу прямоугольного треугольника = {x}");

        }

        static public double checkInput(bool allowZero)
        {
            double x;
            string KeayboardInput = Console.ReadLine();
            while (!Double.TryParse(KeayboardInput, out x) || (!allowZero && x <= 0))
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            Console.Clear();
            return x;
        }
    }
}
