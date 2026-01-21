using System;

namespace _2._32
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 654;

            int c = n / 100;
            int b = (n / 10) % 10;
            int a = n % 10;

            int x = a * 100 + b * 10 + c;
            Console.WriteLine(x);
        }

      

    }
}
