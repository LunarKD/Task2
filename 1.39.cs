using System;

namespace _1._39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x:");
            var x = checkInput(true);
            Console.WriteLine("Введите число y:");
            var y = checkInput(true);
            var z = (x+((2+y)/Math.Pow(x,2)))/(y+(1/Math.Sqrt(Math.Pow(x,2)+10)));
            var q = 2.8*Math.Sin(x)+ Math.Abs(y);
            Console.WriteLine($"z = {z}, q = {q}");

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
