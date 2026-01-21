using System;

namespace _2._35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру а2:");
            int a2 = (int)checkInput(0, 9);
            Console.WriteLine("Введите цифру b2:");
            int b2 = (int)checkInput(0, 9);
            Console.WriteLine("Введите цифру а1:");
            int a1 = (int)checkInput(0, 9);
            Console.WriteLine("Введите цифру b:");
            int b1 = (int)checkInput(0, 9);

            int unitsSum = a1 + b1;
            int c1 = unitsSum % 10;
            int c2 = a2 + b2 + unitsSum / 10;

            Console.WriteLine($"Десятки: {c2}");
            Console.WriteLine($"Единицы: {c1}");
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
