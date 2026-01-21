using System;

namespace _2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число (10-99):");
            int n = (int)checkInput(10,99);

            int tens = n / 10;
            int ones = n % 10;

            Console.WriteLine($"Число десятков в нем {tens}");
            Console.WriteLine($"Число единиц в нем {ones}");
            Console.WriteLine($"Сумму его цифр {tens + ones}");
            Console.WriteLine($"Произведение его цифр {tens * ones}");
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
