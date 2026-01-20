using System;
using System.Linq;

namespace _1._61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение для a:");
            double a = checkInput(false,true);
            Console.WriteLine("Выбирите сценарий выполнения а, б, в, г, д, е, ж, з, и, к или л");
            char inputScen = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (inputScen)
            {
                case 'а':
                    double a2 = a * a;
                    double a4 = a2 * a2;   

                    Console.WriteLine(a4);
                    break;

                case 'б':
                    a2 = a * a;      
                    double a3 = a2 * a;     
                    double a6 = a3 * a3;    

                    Console.WriteLine(a6);
                    break;

                case 'в':
                    a2 = a * a;    
                    a4 = a2 * a2;
                    a6 = a4 * a2;
                    double a7 = a6 * a;

                    Console.WriteLine(a7);
                    break;
                case 'г':
                    a2 = a * a;
                    a4 = a2 * a2;
                    double a8 = a4 * a4;

                    Console.WriteLine(a8);
                    break;
                case 'д':
                    a2 = a * a;
                    a4 = a2 * a2;
                    a8 = a4 * a4;
                    double a9 = a8 * a;

                    Console.WriteLine(a9);
                    break;
                case 'е':
                    a2 = a * a;
                    a4 = a2 * a2;
                    double a5 = a4 * a;
                    double a10 = a5 * a5;

                    Console.WriteLine(a10);
                    break;
                case 'ж':
                    a2 = a * a;
                    a4 = a2 * a2;
                    a8 = a4 * a4;
                    double a12 = a8 * a4;
                    double a13 = a12 * a;

                    Console.WriteLine(a13);
                    break;
                case 'з':
                    a2 = a * a;
                    a3 = a2 * a;
                    a6 = a3 * a3;
                    a12 = a6 * a6;
                    double a15 = a12 * a3;

                    Console.WriteLine(a15);
                    break;
                case 'и':
                    a2 = a * a;
                    a4 = a2 * a2;
                    a5 = a4 * a;
                    a10 = a5 * a5;
                    double a20 = a10 * a10;
                    double a21 = a20 * a;

                    Console.WriteLine(a21);
                    break;
                case 'к':
                    a2 = a * a;
                    a4 = a2 * a2;
                    a8 = a4 * a4;
                    a12 = a8 * a4;
                    double a24 = a12 * a12;
                    double a28 = a24 * a4;

                    Console.WriteLine(a28);
                    break;
                case 'л':
                    a2 = a * a;
                    a4 = a2 * a2;
                    a8 = a4 * a4;
                    double a16 = a8 * a8;
                    double a32 = a16 * a16;
                    double a64 = a32 * a32;

                    Console.WriteLine(a64);
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
