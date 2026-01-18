using System;

namespace _1._45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            var a = checkInput(true);
            Console.WriteLine("Введите число b:");
            var b = checkInput(true);
            Console.WriteLine($"Cумма = {a+b}, разность = {a-b}, произведение = {a*b}, частное = {a/b}");
        }

        static public double checkInput(bool allowZero)
        {
            double x;
            string KeayboardInput = Console.ReadLine();
            while (!Double.TryParse(KeayboardInput, out x) || (!allowZero && x <= 0))
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            Console.Clear();
            return x;
        }
    }
}
