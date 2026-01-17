using System;

namespace _1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];
            Random rnd = new Random();
            for(var i = 0; i<4; i++)
            {
                numbers[i] = rnd.Next(0,100);
                Console.WriteLine($"{numbers[i]}");
            }
        }
    }
}
