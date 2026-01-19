using System;

namespace _1._46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строну a:");
            var a = checkInput(true);
            Console.WriteLine("Введите сторону b:");
            var b = checkInput(true);
            Console.WriteLine("Введите сторону c:");
            var c = checkInput(true);
            var v = a * b * c;
            var sideAre = 2.0 * c * (a + b);
            Console.WriteLine($"Объем прямоугольного паралелепипеда - {v}, площадь боковой поверхности прямоугольного паралелепипеда - {sideAre}");
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
