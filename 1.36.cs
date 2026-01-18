using System;

namespace _1._36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите внешний радиус кольца:");
            var R = checkInput(false);
            Console.WriteLine("Введите внешний радиус кольца:");
            var r = checkInput(false);
            double S = Math.PI * (Math.Pow(R,2) - Math.Pow(r,2));
            Console.WriteLine($"Площадь кольца = {S}");

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
