using System;

namespace _1._48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите основание 1");
            var A = checkInput(false);
            Console.WriteLine("Введите основание 2");
            var B = checkInput(false);
            Console.WriteLine("Введите высоту h");
            var h = checkInput(false);

            var halfDiff = Math.Abs(A - B) / 2.0;
            var leg = Math.Sqrt(h * h + halfDiff * halfDiff);

            var p = A + B + 2.0 * leg;
            Console.WriteLine($"Периметр равнобедренной трапеции - {p}");
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
