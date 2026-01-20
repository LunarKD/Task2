using System;

namespace _1._56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите скорость первого автомобиля (v1>v2):");
            var v1  = checkInput(false, true);
            Console.WriteLine("Введите скорость второго автомобиля (v1>v2):");
            var v2 = checkInput(false, true);
            while(v1>v2)
            {
                Console.WriteLine("Некоретный ввод:");
                Console.WriteLine("Введите скорость второго автомобиля:");
                v2 = checkInput(false, true);
            }
            Console.WriteLine("Введите растояние между автомобилями:");
            var s = checkInput(false, false);

            double distance = s + (v1 - v2) * 0.5;

            Console.WriteLine($"Расстояние между 1 и 2 автомобилями через 30 минут: {distance} ч");

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
