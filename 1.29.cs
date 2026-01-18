using System;

namespace _1._29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите  радиус окружности r:");
            var r = checkInput();
            var c = 2 * Math.PI * r;
            var s = Math.PI * Math.Pow(r,2);
            Console.WriteLine($"Длину окружности - {c},  площадь круга - {s}");


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
