using System;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int input = checkInput();
            Console.WriteLine($"{input} - вот какое число Вы ввели");
        }

        static public int checkInput()
        {
            int x;
            string KeayboardInput = Console.ReadLine();
            while (!Int32.TryParse(KeayboardInput, out x))
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            Console.Clear();
            return x;
        }
    }
}
