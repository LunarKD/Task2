using System;

namespace _1._43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            var a = checkInput(true);
            Console.WriteLine("Введите число b:");
            var b = checkInput(true);
            var arithmetic = (Math.Abs(a) + Math.Abs(b)) / 2.0;
            var geometric = Math.Sqrt(Math.Abs(a)*Math.Abs(b));
            Console.WriteLine($"Среднее арифметическое = {arithmetic}, среднее геометрическое = {geometric}");

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
