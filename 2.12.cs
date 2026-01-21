using System;

namespace _2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число (100-999):");
            int n = (int)checkInput(100,999);

            int ones = n / 100;
            int tens = (n / 10) % 10;
            int hundreds = n % 10;

            Console.WriteLine($"Число единиц в нем {ones}");
            Console.WriteLine($"Число десятков в нем {tens}");
            Console.WriteLine($"Сумму его цифр {ones + tens + hundreds}");
            Console.WriteLine($"Произведение его цифр {ones * tens * hundreds}");
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
