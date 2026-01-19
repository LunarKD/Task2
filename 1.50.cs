using System;

namespace _1._50
{
    class Program
    {
        static void Main(string[] args)
        {
            (double x, double y)[] pts = new (double x, double y)[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Введите x{i + 1}");
                double x = checkInput(true);
                Console.WriteLine($"Введите y{i + 1}");
                double y = checkInput(true);
                pts[i] = (x, y);
            }

            double p = Dist(pts[0], pts[1]) + Dist(pts[1], pts[2]) + Dist(pts[2], pts[0]);

            double s = Math.Abs(
                pts[0].x * (pts[1].y - pts[2].y) +
                pts[1].x * (pts[2].y - pts[0].y) +
                pts[2].x * (pts[0].y - pts[1].y)
            ) / 2.0;

            Console.WriteLine($"Периметр треугольника - {p}, площадь треугольника - {s}");
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
        static double Dist((double x, double y) a, (double x, double y) b)
        {
            return Math.Sqrt((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y));
        }
    }
}
