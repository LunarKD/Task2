using System;

namespace _2._28
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 546;

            int b = n / 100;
            int a = (n / 10) % 10;
            int c = n % 10;

            int x = a * 100 + b * 10 + c;

            Console.WriteLine(x);
        }

      

    }
}
