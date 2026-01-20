using System;

namespace _1._60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной a:");
            var a = checkInput(true,false);
            Console.WriteLine("Введите значение переменной b:");
            var b = checkInput(true,false);
            Console.WriteLine("Введите значение переменной c:");
            var c = checkInput(true, false);

            double oldA = a;
            double oldB = b;
            double oldC = c;

            b = oldC;
            a = oldB;
            c = oldA;
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            b = oldA;
            c = oldB;
            a = oldC;
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");

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
