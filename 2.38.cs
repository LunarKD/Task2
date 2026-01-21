using System;

namespace _2._38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число k (от 1 до 150):");
            int k = (int)checkInput(1, 150);

            int index = (k - 1) / 3;
            int number = 101 + index;
            int pos = (k - 1) % 3;

            int digit = (number / (int)Math.Pow(10, 2 - pos)) % 10;

            Console.WriteLine(digit);
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
