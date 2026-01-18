using System;

namespace _1._26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности r:");
            var r = checkInput();
            Console.WriteLine($"Диаметр окружности = {2*r}");


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
