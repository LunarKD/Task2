using System;

namespace _1._44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону a:");
            var a = checkInput(false);
            Console.WriteLine("Введите сторону b:");
            var b = checkInput(false);
            var p = 2 * (a + b);
            var d = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
            Console.WriteLine($"Периметр прямоугольника = {p}, длина диагонали прямоугольника = {d}");
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
