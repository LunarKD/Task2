using System;

namespace _2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число до 365");
            int k = (int)checkInput(365);
            Console.WriteLine("Введите каким днём является 1 января");
            Console.WriteLine($"1 - {dayOfWeak(1)}, 2 - {dayOfWeak(2)}, 3 - {dayOfWeak(3)}, 4 - {dayOfWeak(4)}," +
                                $"5 - {dayOfWeak(5)}, 6 - {dayOfWeak(6)}, 7 - {dayOfWeak(7)}");
            int d = (int)checkInput(7);
            int a = k % 7;
            int b = (k - 1 + 2) % 7;
            int c = (k - 1 + d) % 7;
            Console.WriteLine($"Если 1 января понедельник то день {k} - {dayOfWeak(a)}");
            Console.WriteLine($"Если 1 января вторник то день {k} - {dayOfWeak(b)}");
            Console.WriteLine($"Если 1 января {dayOfWeak(d)} то день {k} - {dayOfWeak(c)}");


        }
        static public double checkInput(int max)
        {
            double x;
            string KeayboardInput = Console.ReadLine();
            while (!Double.TryParse(KeayboardInput, out x) || x <= 0 || x > max)
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            return x;
        }
        static public string dayOfWeak(int day)
        {
            string dayString = "";
            switch (day)
            {
                case 1:
                    dayString = "Понедельник";
                    break;
                case 2:
                    dayString = "Вторник";
                    break;
                case 3:
                    dayString = "Среда";
                    break;
                case 4:
                    dayString = "Четверг";
                    break;
                case 5:
                    dayString = "Пятница";
                    break;
                case 6:
                    dayString = "Суббота";
                    break;
                case 7:
                    dayString = "Воскресение";
                    break;
            }
            return dayString;
        }

    }
}
