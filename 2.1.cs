using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество см:");
            int cm = (int)checkInput(true,false);
            Console.WriteLine($"Число полных метров: {cm/100}");
            

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
