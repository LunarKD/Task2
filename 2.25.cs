using System;

namespace _2._25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число (10 - 999):");
            int n = (int)checkInput(10,999);

            int c = n / 100;
            int ab = n % 100;
            int x = ab * 10 + c;

            Console.WriteLine(x);
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

