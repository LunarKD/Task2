using System;

namespace _2._43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a (от 0):");
            int a = (int)checkInput(0);
            Console.WriteLine("Введите число b (от 0):");
            int b = (int)checkInput(0);

            bool check = (b != 0 && a % b == 0) || (a != 0 && b % a == 0);
            int result = Convert.ToInt32(check);

            Console.WriteLine(result);
        }
        static public double checkInput(int min)
        {
            double x;
            string KeayboardInput = Console.ReadLine();
            while (!Double.TryParse(KeayboardInput, out x) || x < min )
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            return x;
        }
    }
}
