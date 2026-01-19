using System;

namespace _1._52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стоимость конфет:");
            var priceCandy = checkInput(false, true);
            Console.WriteLine("Введите стоимость печенья:");
            var priceCookies = checkInput(false, true);
            Console.WriteLine("Введите стоимость яблок:");
            var priceApples = checkInput(false, true);
            Console.WriteLine($"Стоимость: конфет - {priceCandy}, печенья - {priceCookies}, яблок - {priceApples}");
            Console.WriteLine("Введите сколько конфет вы хотите купить (кг):");
            var countCandy = checkInput(false, false);
            Console.WriteLine("Введите сколько печенья вы хотите купить (кг):");
            var countCookies = checkInput(false, false);
            Console.WriteLine("Введите сколько яблок вы хотите купить (кг):");
            var countApples = checkInput(false, false);

            double total = priceCandy * countCandy + priceCookies * countCookies + priceApples * countApples;
            Console.WriteLine($"Стоимость всей покупки: {total}");

        }

        static public double checkInput(bool allowZero,bool cleanConsole)
        {
            double x;
            string KeayboardInput = Console.ReadLine();
            while (!Double.TryParse(KeayboardInput, out x) || (!allowZero && x < 0))
            {
                Console.WriteLine("Некоректный ввод!");
                KeayboardInput = Console.ReadLine();
            }
            if(cleanConsole)
                Console.Clear();
            return x;
        }

    }
}
