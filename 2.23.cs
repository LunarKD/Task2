using System;

namespace _2._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число (1000 - 9999):");
            int n = (int)checkInput(1000,9999);
            Console.Clear();
            int hundreds = (n / 100) % 10;
            int thousands = (n / 1000) % 10;

            Console.WriteLine($"Сотен: {hundreds}");
            Console.WriteLine($"Тысяч: {thousands}");
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
