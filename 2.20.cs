using System;

namespace _2._20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число (1000-9999):");
            int n = (int)checkInput(1000,9999);
            Console.Clear();
            int thousands = n / 1000;
            int tens = (n / 100) % 10;
            int ones = (n / 10) % 10;
            int hundreds = n % 10;

            int rev = hundreds * 1000 + ones * 100 + tens * 10 + thousands;

            int swap12_34 = tens * 1000 + thousands * 100 + hundreds * 10 + ones;

            int swap23 = thousands * 1000 + ones * 100 + tens * 10 + hundreds;

            int swapPairs_digits = ones * 1000 + hundreds * 100 + thousands * 10 + tens;

            int first2 = n / 100;
            int last2 = n % 100;
            int swapPairs_math = last2 * 100 + first2;

            Console.WriteLine(rev);
            Console.WriteLine(swap12_34);
            Console.WriteLine(swap23);
            Console.WriteLine(swapPairs_digits);
            Console.WriteLine(swapPairs_math);
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
      

    }
}
