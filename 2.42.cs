using System;

namespace _2._42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число h (от 0 до 12):");
            int h = (int)checkInput(0, 12);
            Console.WriteLine("Введите число m (от 0 до 59):");
            int m = (int)checkInput(0, 59);

            int startTotal = (h % 12) * 60 + m;

            int tCoincide = FindMinT(startTotal, false);
            int tPerp = FindMinT(startTotal, true);

            Console.WriteLine($"а) До совпадения: {tCoincide} мин");
            Console.WriteLine($"б) До перпендикуляра: {tPerp} мин");
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
        static int FindMinT(int startTotalMinutes, bool needPerpendicular)
        {
            for (int t = 0; t <= 12 * 60; t++)
            {
                int total = startTotalMinutes + t;
                int hh = (total / 60) % 12;
                int mm = total % 60;

                int hourAngle2 = (hh * 60 + mm) % 720;
                int minAngle2 = (mm * 12) % 720;

                int diff = Math.Abs(hourAngle2 - minAngle2);
                diff = Math.Min(diff, 720 - diff);

                if (!needPerpendicular)
                {
                    if (diff == 0) return t;
                }
                else
                {
                    if (diff == 180) return t; // 90° = 180 "полуградусов"
                }
            }
            return -1;
        }


    }
}
