using System;

namespace _2._33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число (1 - 999):");
            int n = (int)checkInput(1,999);

            int c = n / 100;
            int ba = n % 100;
            int b = ba / 10;
            int a = ba % 10;

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
