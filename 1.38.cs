using System;

namespace _1._38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту равнобедренной трапеции:");
            var h = checkInput(false);
            Console.WriteLine("Введите большее основание равнобедренной трапеции:");
            var A = checkInput(false);
            Console.WriteLine("Введите меньшее основание равнобедренной трапеции:");
            var B  = checkInput(false);
            var halfDiff = Math.Abs(A - B) / 2.0;
            var leg = Math.Sqrt(Math.Pow(h,2) + Math.Pow(halfDiff,2));
            var P = A + B + 2 * leg;
            Console.WriteLine($"Периметр равнобедренной трапеции = {P}");

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
