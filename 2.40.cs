using System;

namespace _2._40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число y (от 0 до 360):");
            int y = (int)checkInput(0, 360);

            double totalMinutes = 2.0 * y;

            int hours = (int)(totalMinutes / 60.0);
            int minutes = (int)(totalMinutes % 60.0);

            Console.WriteLine($"Часы: {hours}");
            Console.WriteLine($"Минуты: {minutes}");
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
