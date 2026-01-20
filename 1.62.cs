using System;

namespace _1._62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение для a:");
            double a = checkInput(false,true);
            Console.WriteLine("Выбирите сценарий выполнения а, б, в, г, д или е");
            char inputScen = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (inputScen)
            {
                case 'а':
                    double a2 = a * a;
                    double a3 = a2 * a;
                    double a5 = a3 * a2;
                    double a10 = a5 * a5;

                    Console.WriteLine(a3);
                    Console.WriteLine(a10);
                    break;

                case 'б':
                    a2 = a * a;
                    double a4 = a2 * a2;
                    a5 = a4 * a;
                    a10 = a5 * a5;
                    double a20 = a10 * a10;

                    Console.WriteLine(a4);
                    Console.WriteLine(a20);
                    break;

                case 'в':
                    a2 = a * a;
                    a3 = a2 * a;
                    a5 = a3 * a2;
                    a10 = a5 * a5;
                    double a13 = a10 * a3;

                    Console.WriteLine(a5);
                    Console.WriteLine(a13);
                    break;
                case 'г':
                    a2 = a * a;
                    a4 = a2 * a2;
                    a5 = a4 * a;
                    double a9 = a5 * a4;
                    double a19 = a9 * a9 * a;

                    Console.WriteLine(a5);
                    Console.WriteLine(a19);
                    break;
                case 'д':
                    a2 = a * a;
                    a4 = a2 * a2;
                    a5 = a4 * a;
                    a10 = a5 * a5;
                    double a15 = a10 * a5;
                    double a17 = a15 * a2;

                    Console.WriteLine(a2);
                    Console.WriteLine(a5);
                    Console.WriteLine(a17);
                    break;
                case 'е':
                    a2 = a * a;
                    a4 = a2 * a2;
                    double a8 = a4 * a4;
                    double a12 = a8 * a4;
                    double a24 = a12 * a12;
                    double a28 = a24 * a4;

                    Console.WriteLine(a4);
                    Console.WriteLine(a12);
                    Console.WriteLine(a28);
                    break;
            }

        }
        static public double checkInput(bool allowZero, bool cleanConsole)
        {
            double x;
            string KeayboardInput = Console.ReadLine();
            while (!Double.TryParse(KeayboardInput, out x) || (!allowZero && x < 0))
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            if (cleanConsole)
                Console.Clear();
            return x;
        }

    }
}
