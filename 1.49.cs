using System;

namespace _1._49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите большее основание");
            var A = checkInput(false);
            Console.WriteLine("Введите большее основание");
            var B = checkInput(false);
            Console.WriteLine("Введите угол при большем основании alpha");
            var alpha = checkInput(false);

            var h = (Math.Abs(A - B) / 2.0) * Math.Tan(alpha);
            var S = (A + B) / 2.0 * h;
            Console.WriteLine($"Площадь трапеции - {S}");
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
