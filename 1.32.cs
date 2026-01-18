using System;

namespace _1._32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите объем тела:");
            var v = checkInput();
            Console.WriteLine("Введите массу тела:");
            var m = checkInput();
            var p = m / v;
            Console.WriteLine($"Плотность материала этого тела - {p}");

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
