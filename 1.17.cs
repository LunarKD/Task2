using System;

namespace _1._17
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
                    Console.WriteLine("Введите число x1");
                    int x1 = checkInput();
                    Console.WriteLine("Введите число x2");
                    int x2 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{Math.Sqrt(Math.Pow(x1,2)+Math.Pow(x2,2))}");
                    break;

                case 'б':
                    Console.WriteLine("Введите число x1");
                    int x3 = checkInput();
                    Console.WriteLine("Введите число x2");
                    int x4 = checkInput();
                    Console.WriteLine("Введите число x3");
                    int x5 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{x3*x4+x3*x5+x4*x5}");
                    break;

                case 'в':
                    Console.WriteLine("Введите число V0");
                    int V0 = checkInput();
                    Console.WriteLine("Введите число a");
                    int a = checkInput();
                    Console.WriteLine("Введите число t");
                    int t = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{V0*t+(a*Math.Pow(t,2)/2)}");
                    break;
                case 'г':
                    Console.WriteLine("Введите число m");
                    int m = checkInput();
                    Console.WriteLine("Введите число v");
                    int v = checkInput();
                    Console.WriteLine("Введите число g");
                    int g = checkInput();
                    Console.WriteLine("Введите число h");
                    int h = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(m*Math.Pow(v,2)/2)+ m*g*h}");
                    break;
                case 'д':
                    Console.WriteLine("Введите число R1");
                    int R1 = checkInput();
                    Console.WriteLine("Введите число R2");
                    int R2 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(1/R1)+(1/R2)}");
                    break;
                case 'е':
                    Console.WriteLine("Введите число alpha");
                    int alpha = checkInput();
                    Console.WriteLine("Введите число m");
                    int m2 = checkInput();
                    Console.WriteLine("Введите число g");
                    int g2 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{m2*g2*Math.Cos(alpha)}");
                    break;
                case 'ж':
                    Console.WriteLine("Введите число R");
                    int R3 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{2*Math.PI*R3}");
                    break;
                case 'з':
                    Console.WriteLine("Введите число a");
                    int a2 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b = checkInput();
                    Console.WriteLine("Введите число c");
                    int c = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{Math.Pow(b,2)-4*a2*c}");
                    break;
                case 'и':
                    Console.WriteLine("Введите число m1");
                    int m3 = checkInput();
                    Console.WriteLine("Введите число m2");
                    int m4 = checkInput();
                    Console.WriteLine("Введите число r");
                    int r = checkInput();
                    Console.WriteLine("Введите число gamma");
                    int gamma = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{gamma*((m3*m4)/Math.Pow(r,2))}");
                    break;
                case 'к':
                    Console.WriteLine("Введите число I");
                    int I = checkInput();
                    Console.WriteLine("Введите число R");
                    int R = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{Math.Pow(I,2)*R}");
                    break;
                case 'л':
                    Console.WriteLine("Введите число a");
                    int a3 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b2 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c2 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{a3*b2*Math.Sin(c2)}");
                    break;
                case 'м':
                    Console.WriteLine("Введите число a");
                    int a4 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b3 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c3 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{Math.Sqrt(Math.Pow(a4,2)+Math.Pow(b3,2)-2*a4*b3*Math.Cos(c3))}");
                    break;
                case 'н':
                    Console.WriteLine("Введите число a");
                    int a5 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b4 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c4 = checkInput();
                    Console.WriteLine("Введите число d");
                    int d = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(a5*d+b4*c4)/(a5*d)}");
                    break;
                case 'о':
                    Console.WriteLine("Введите число x");
                    int x = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{Math.Sqrt(1-Math.Pow(Math.Sin(x),2))}");
                    break;
                case 'п':
                    Console.WriteLine("Введите число a");
                    int a6 = checkInput();
                    Console.WriteLine("Введите число b");
                    int b5 = checkInput();
                    Console.WriteLine("Введите число c");
                    int c5 = checkInput();
                    Console.WriteLine("Введите число x");
                    int x6 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{1/Math.Sqrt(a6*Math.Pow(x6,2)+b5*x6+c5)}");
                    break;
                case 'р':
                    Console.WriteLine("Введите число x");
                    int x7 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{(Math.Sqrt(x7+1)+Math.Sqrt(x7-1))/2*Math.Sqrt(x7)}");
                    break;
                case 'с':
                    Console.WriteLine("Введите число x");
                    int x8 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{Math.Abs(x8)+Math.Abs(x8+1)}");
                    break;
                case 'т':
                    Console.WriteLine("Введите число x");
                    int x9 = checkInput();
                    Console.Clear();
                    Console.WriteLine($"{Math.Abs(1-Math.Abs(x9))}");
                    break;
            }
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
