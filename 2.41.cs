using System;

namespace _2._41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число y (от 0 до 2П):");
            double y = checkInput(0, 2 * Math.PI);

            double totalHours = (y / (2.0 * Math.PI)) * 12.0;
            double totalMinutes = totalHours * 60.0;

            int h = (int)totalHours;
            int m = (int)(totalMinutes - h * 60.0);

            
            double minuteAngle = ((totalMinutes % 60.0) / 60.0) * 2.0 * Math.PI;

            Console.WriteLine($"Угол минутной (рад): {minuteAngle}");
            Console.WriteLine($"Полных часов: {h}");
            Console.WriteLine($"Полных минут: {m}");
        }
        static public double checkInput(int min, double max)
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
