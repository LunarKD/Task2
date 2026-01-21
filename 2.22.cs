using System;

namespace _2._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число (100 - 999):");
            int n = (int)checkInput(100,999);
            Console.Clear();
            int tens = (n / 10) % 10;
            int hundreds = (n / 100) % 10;

            Console.WriteLine($"Десятков: {tens}");
            Console.WriteLine($"Сотен: {hundreds}");
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
