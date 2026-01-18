using System;

namespace _1._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            double a = checkInput();
            double y = (Math.Pow(a,2)+10)/Math.Sqrt(Math.Pow(a,2)+1);
            Console.WriteLine($"y = {y}");
                   
            
        }

        static public double checkInput()
        {
            double x;
            string KeayboardInput = Console.ReadLine();
            while (!Double.TryParse(KeayboardInput, out x))
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            Console.Clear();
            return x;
        }
    }
}
