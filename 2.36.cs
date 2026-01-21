using System;

namespace _2._36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру а3:");
            int a3 = (int)checkInput(0, 9);
            Console.WriteLine("Введите цифру а2:");
            int a2 = (int)checkInput(0, 9);
            Console.WriteLine("Введите цифру b2:");
            int b2 = (int)checkInput(0, 9);
            Console.WriteLine("Введите цифру а1:");
            int a1 = (int)checkInput(0, 9);
            Console.WriteLine("Введите цифру b1:");
            int b1 = (int)checkInput(0, 9);

            int s1 = a1 + b1;
            int c1 = s1 % 10;
            int carry1 = s1 / 10;

            int s2 = a2 + b2 + carry1;
            int c2 = s2 % 10;
            int carry2 = s2 / 10;

            int c3 = a3 + carry2;

            Console.WriteLine($"Сотни: {c3}");
            Console.WriteLine($"Десятки: {c2}");
            Console.WriteLine($"Единицы: {c1}");
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
