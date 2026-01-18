using System;

namespace _1._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирите сценарий выполнения а, б, в, г, д, е, ж, з, и, к, л, м, н, о, п, р, с или т");
            char inputScen = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (inputScen)
            {
                case 'а':
                    double s = 5;
                    s = 57;
                    Console.WriteLine($"{s}");
                    break;

                case 'б':
                    double s2 = 6;
                    s2 = -5.2*s2;
                    s2 = 0;
                    Console.WriteLine($"{s2}");
                    break;

                case 'в':
                    double s3 = -7.5;
                    s3 = 2 * s3;
                    Console.WriteLine($"{s3}");
                    break;
                case 'г':
                    Console.WriteLine("Введите число k");
                    double k = checkInput();
                    double s4 = 45;
                    s4 = -25;
                    s4 = s4 + k;
                    Console.WriteLine($"{s4}");
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
