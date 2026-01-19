using System;

namespace _1._51
{
    class Program
    {
        static void Main(string[] args)
        {
            (double x, double y)[] pts = new (double x, double y)[4];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Введите x{i + 1}");
                double x = checkInput(true);
                Console.WriteLine($"Введите y{i + 1}");
                double y = checkInput(true);
                pts[i] = (x, y);
            }

            double s = TriangleArea(pts[0].x, pts[0].y, pts[1].x, pts[1].y, pts[2].x, pts[2].y) +
                TriangleArea(pts[0].x, pts[0].y, pts[2].x, pts[2].y, pts[3].x, pts[3].y);

            Console.WriteLine($"Площадь четырехугольника - {s}");
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
        static double TriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0;
        }
    }
}
