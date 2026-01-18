using System;

namespace _1._41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число e:");
            var e = checkInput(true);
            Console.WriteLine("Введите число f:");
            var f = checkInput(true);
            Console.WriteLine("Введите число g:");
            var g = checkInput(true);
            Console.WriteLine("Введите число h:");
            var h = checkInput(true);
            var a = Math.Sqrt(Math.Pow(Math.Abs(e-(3.0/f)),3.0)+g);
            var b = Math.Sin(e)+Math.Pow(Math.Cos(h),2.0);
            var c = (33.0*g) / (e*f-3.0);
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");

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
