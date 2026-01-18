using System;

namespace _1._42
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
            var a = (e+(f/2))/3;
            var b = Math.Abs(Math.Pow(h,2)-g);
            var c = Math.Sqrt(Math.Pow(g-h,2)-3*Math.Sin(e));
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
