using System;

namespace _2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сколько месяцев прошло с начала 1990 года (от 0 до 11)");
            int m = (int)checkInput(11);
            Console.WriteLine($"Это будет - {monthOfYear(m + 1)} 1990 г");
        }
        static public double checkInput(int max)
        {
            double x;
            string KeayboardInput = Console.ReadLine();
            while (!Double.TryParse(KeayboardInput, out x) || x < 0 || x > max)
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            return x;
        }
        static public string monthOfYear(int day)
        {
            string dayString = "";
            switch (day)
            {
                case 1:
                    dayString = "Январь";
                    break;
                case 2:
                    dayString = "Февраль";
                    break;
                case 3:
                    dayString = "Март";
                    break;
                case 4:
                    dayString = "Апрель";
                    break;
                case 5:
                    dayString = "Май";
                    break;
                case 6:
                    dayString = "Июнь";
                    break;
                case 7:
                    dayString = "Июль";
                    break;
                case 8:
                    dayString = "Август";
                    break;
                case 9:
                    dayString = "Сентябрь";
                    break;
                case 10:
                    dayString = "Октябрь";
                    break;
                case 11:
                    dayString = "Ноябрь";
                    break;
                case 12:
                    dayString = "Декабрь";
                    break;
            }
            return dayString;
        }

    }
}
