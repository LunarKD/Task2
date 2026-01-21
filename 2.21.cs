using System;

namespace _2._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число (10 - 99):");
            int n = (int)checkInput(10,99);
            Console.Clear();
            int ones = n % 10;
            int tens = (n / 10) % 10;

            Console.WriteLine($"Единиц: {ones}");
            Console.WriteLine($"Десятков: {tens}");
        }
        static public double checkInput(int min, int max)
        {
            double x;
            string KeayboardInput = Console.ReadLine();
            while (!Double.TryParse(KeayboardInput, out x) || x < min || x > max)
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            return x;
        }
      

    }
}

