using System;

namespace _2._29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число (10 - 999):");
            int n = (int)checkInput(10,999);

            int b = n / 100;
            int ac = n % 100;
            int a = ac / 10;
            int c = ac % 10;

            int x = a * 100 + b * 10 + c;
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
