using System;

namespace _1._55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите скорость первого автомобиля:");
            var v1  = checkInput(false, false);
            Console.WriteLine("Введите скорость второго автомобиля:");
            var v2 = checkInput(false, false);
            Console.WriteLine("Введите растояние между автомобилями:");
            var s = checkInput(false, false);

            double t = s/(v1+v2);

            Console.WriteLine($"Автомобили встретятся через: {t} ч");

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
