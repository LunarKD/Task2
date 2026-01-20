using System;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние м:");
            int m = (int)checkInput(true,false);
            Console.WriteLine($"Число полных километров: {m/1000}");
            

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
