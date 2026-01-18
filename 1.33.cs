using System;

namespace _1._33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество жителей в государстве:");
            var people = checkInput();
            Console.WriteLine("Введите площадь территории государства:");
            var s = checkInput();
            var p = people / s;
            Console.WriteLine($"Плотность населения в этом государстве - {p}");

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
