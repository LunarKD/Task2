using System;

namespace _1._30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирите сценарий выполнения а или б");
            char inputScen = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (inputScen)
            {
                case 'а':
                    Console.WriteLine("Введите число x:");
                    double x = checkInput();
                    Console.WriteLine("Введите число y:");
                    double y = checkInput();
                    double z = Math.Pow(x,3)-2.5*x*y+1.78*Math.Pow(x,2)-2.5*y+1;
                    Console.WriteLine($"z = {z}");
                    break;

                case 'б':
                    Console.WriteLine("Введите число a:");
                    double a = checkInput();
                    Console.WriteLine("Введите число b:");
                    double b = checkInput();
                    double x2 = 3.56*a+Math.Pow(b,3)-5.8*Math.Pow(b,2)+3.8*a-1.5;
                    Console.WriteLine($"x = {x2}");
                    break;
            }


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
