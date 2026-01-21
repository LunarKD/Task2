using System;

namespace _2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число (10-99):");
            int n = (int)checkInput(10,99);

            int tens = n / 10;
            int ones = n % 10;

            int swapped = ones * 10 + tens;
            Console.WriteLine(swapped);
        }
        static public double checkInput(int min, int max)
        {
            double x;
            string KeayboardInput = Console.ReadLine();
            while (!Double.TryParse(KeayboardInput, out x) || x < min || x > max)
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            return x;
        }
      

    }
}
