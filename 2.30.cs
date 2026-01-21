using System;

namespace _2._30
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 456;

            int a = res / 100;
            int c = (res / 10) % 10;
            int b = res % 10;

            int x = a * 100 + b * 10 + c;
            Console.WriteLine(x);
        }
        
      

    }
}
