using System;

namespace _1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            Random rnd = new Random();
            for(var i = 0; i<3; i++)
            {
                numbers[i] = rnd.Next(0,100);
            }
            Console.WriteLine($"{numbers[0]}  {numbers[1]}  {numbers[2]}");
        }
    }
}
