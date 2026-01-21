using System;

namespace _2._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число (100-999):");
            int n = (int)checkInput(100,999);

            int hundreds = n % 10;
            int rest = n / 10;

            Console.WriteLine(hundreds * 100 + rest);
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
