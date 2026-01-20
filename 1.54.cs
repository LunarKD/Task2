using System;

namespace _1._54
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст Тани:");
            var ageTani  = checkInput(false, true);
            Console.WriteLine("Введите возраст Мити:");
            var ageMiti = checkInput(false, true);

            var avg = (ageMiti + ageTani) / 2.0;

            Console.WriteLine($"Их средний возраст: {avg}, Таня {(ageTani-avg>0? "старше": "младше")} на {Math.Abs(ageTani - avg)}, " +
                $"Мити {(ageMiti - avg > 0 ? "старше" : "младше")} на {Math.Abs(ageMiti - avg)}");

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
