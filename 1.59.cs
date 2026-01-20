using System;

namespace _1._59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной a:");
            var a = checkInput(true,false);
            Console.WriteLine("Введите значение переменной b:");
            var b = checkInput(true,false);
            var t = a;
            a = b;
            b = t;
            Console.WriteLine($"a = {a}, b = {b}");
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
