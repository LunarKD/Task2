using System;

namespace _2._37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число k (от 1 до 180):");
            int k = (int)checkInput(1, 180);

            int pairIndex = (k + 1) / 2;
            int number = 10 + (pairIndex - 1);

            int digit = (k % 2 == 1) ? (number / 10) : (number % 10);

            Console.WriteLine($"а) Номер пары: {pairIndex}");
            Console.WriteLine($"б) Число пары: {number}");
            Console.WriteLine($"в) k-я цифра: {digit}");
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
