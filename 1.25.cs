using System;

namespace _1._25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дину стороны квадрат a:");
            var a = checkInput();
            Console.WriteLine($"Периметр квадрата = {4*a}");


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
