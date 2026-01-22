using System;

namespace _2._39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число h (от 0 до 23):");
            int h = (int)checkInput(0, 23);
            Console.WriteLine("Введите число m (от 0 до 59):");
            int m = (int)checkInput(0, 59);
            Console.WriteLine("Введите число s (от 0 до 5s9):");
            int s = (int)checkInput(0, 59);

            double angle = (h % 12) * 30.0 + m * 0.5 + s * (0.5 / 60.0);

            Console.WriteLine(angle);
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
