using System;

namespace _1._37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый катет:");
            var a = checkInput(false);
            Console.WriteLine("Введите второй катет:");
            var b = checkInput(false);
            var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            var P = a + b + c;
            Console.WriteLine($"Периметр прямоугольного треугольника = {P}");

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
