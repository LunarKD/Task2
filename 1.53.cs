using System;

namespace _1._53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стоимость монитора:");
            var priceMonitor  = checkInput(false, true);
            Console.WriteLine("Введите стоимость системного блока:");
            var priceSystemUnit = checkInput(false, true);
            Console.WriteLine("Введите стоимость клавиатуры:");
            var priceKeyboard = checkInput(false, true);
            Console.WriteLine("Введите стоимость мыши:");
            var priceMouse = checkInput(false, true);
            var onePC = priceMonitor + priceKeyboard + priceSystemUnit + priceMouse;
            Console.WriteLine($"Стоимость одного ПК: {onePC}");
            Console.WriteLine("Введите сколько ПК вы хотите купить:");
            int countPC = (int)checkInput(false, false);

            double threeTotal = 3 * onePC;
            double NTotal = countPC * onePC;
            Console.WriteLine($"Стоимость трех ПК: {threeTotal}, стоимость {countPC} ПК: {NTotal}");

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
