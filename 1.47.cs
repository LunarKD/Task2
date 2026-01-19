using System;

namespace _1._47
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] points = new double[4];
           for(var i = 0; i<points.Length;i++)
           {
                if(i%2 == 0)
                {
                    Console.WriteLine($"Введите x");
                    points[i] = checkInput(true);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Введите y");
                    points[i] = checkInput(true);
                    Console.Clear();
                }
           }
           double d = Math.Sqrt((points[0] - points[2]) * (points[2] - points[0]) + (points[3] - points[1]) * (points[3] - points[1]));
           Console.WriteLine($"Расстояния между x1y1 и x2y2 = {d}");

        }

        static public double checkInput(bool allowZero)
        {
            double x;
            string KeayboardInput = Console.ReadLine();
            while (!Double.TryParse(KeayboardInput, out x) || (!allowZero && x <= 0))
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            Console.Clear();
            return x;
        }
    }
}
