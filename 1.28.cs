using System;

namespace _1._28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба a:");
            var a = checkInput();
            var v = Math.Pow(a,3);
            var sSide = 4 * Math.Pow(a,2);
            Console.WriteLine($"Объем куба - {v},  площадь боковой поверхности куба - {sSide}");


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
