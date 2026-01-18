using System;

namespace _1._40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            var a = checkInput(true);
            Console.WriteLine("Введите число b:");
            var b = checkInput(true);
            var x = (2/(Math.Pow(a,2)+25)+b)/(Math.Sqrt(b)+((a+b)/2));
            var y = (Math.Abs(a)+2*Math.Sin(b))/(5.5*a);
            Console.WriteLine($"x = {x}, y = {y}");

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
