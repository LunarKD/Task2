using System;

namespace _1._24
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
                    Console.WriteLine("Введите число a:");
                    double a = checkInput();
                    double x = Math.Sqrt((2*a+Math.Sin(Math.Abs(3*a)))/3.56);
                    Console.WriteLine($"x = {x}");
                    break;

                case 'б':
                    Console.WriteLine("Введите число x:");
                    double x2 = checkInput();
                    double y = Math.Sin((3.2+Math.Sqrt(1+x2))/Math.Abs(5*x2));
                    Console.WriteLine($"y = {y}");
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
