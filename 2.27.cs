using System;

namespace _2._27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число (1 - 999):");
            int n = (int)checkInput(1,999);

            int a = n % 10;
            int bc = n / 10;
            int x = a * 100 + bc;

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
