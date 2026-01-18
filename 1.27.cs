using System;

namespace _1._27
{
    class Program
    {
        static void Main(string[] args)
        {
            const double R = 6350;
            Console.WriteLine("Введите точки с заданной высотой над Землей h:");
            var h = checkInput();
            var d = Math.Sqrt((R + h) * (R + h) - Math.Pow(R, 2));
            Console.WriteLine($"Расстояние до линии горизонта = {d}");


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
