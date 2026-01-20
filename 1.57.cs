using System;

namespace _1._57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру в C:");
            var c  = checkInput(true, true);


            double f = 1.8 * c + 32.0;
            double k = c + 273.15;

            Console.WriteLine($"Температура в Цельсия: {c}, температура в Фаренгейта: {f}, температура в Кельвина: {k}.");

        }

        static public double checkInput(bool allowZero,bool cleanConsole)
        {
            double x;
            string KeayboardInput = Console.ReadLine();
            while (!Double.TryParse(KeayboardInput, out x) || (!allowZero && x < 0))
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            if(cleanConsole)
                Console.Clear();
            return x;
        }

    }
}
