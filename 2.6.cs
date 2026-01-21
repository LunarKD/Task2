using System;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество секунд которое  прошло с начала суток");

            var n = (int)checkInput(false, false);

            int hours = n / 3600;
            int minutes = (n % 3600) / 60;
            int seconds = n % 60;

            Console.WriteLine($"с начала суток прошло {hours} часов");
            Console.WriteLine($"с начала суток прошло {minutes} минут");
            Console.WriteLine($"с начала суток прошло {seconds} секунд");


        }
        static public double checkInput(bool allowZero, bool cleanConsole)
        {
            double x;
            string KeayboardInput = Console.ReadLine();
            while (!Double.TryParse(KeayboardInput, out x) || (!allowZero && x < 0))
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            if (cleanConsole)
                Console.Clear();
            return x;
        }

    }
}
