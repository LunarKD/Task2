using System;

namespace _2._26
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 564;

            int b = result / 100;
            int c = (result / 10) % 10;
            int a = result % 10;

            int x = a * 100 + b * 10 + c;

            Console.WriteLine(x);
        }
        

    }
}
