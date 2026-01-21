using System;

namespace _2._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число (100-999):");
            int n = (int)checkInput(100,999);
            Console.Clear();
            int ones = n / 100;
            int tens = (n / 10) % 10;
            int hundreds = n % 10;

            Console.WriteLine(ones * 100 + tens * 10 + hundreds);
            Console.WriteLine(ones * 100 + hundreds * 10 + tens);
            Console.WriteLine(tens * 100 + ones * 10 + hundreds);
            Console.WriteLine(tens * 100 + hundreds * 10 + ones);
            Console.WriteLine(hundreds * 100 + ones * 10 + tens);
            Console.WriteLine(hundreds * 100 + tens * 10 + ones);
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
