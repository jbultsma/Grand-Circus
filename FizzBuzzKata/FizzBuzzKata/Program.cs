using System;

namespace FizzBuzzKata
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;

            for (int j = 0; j<=7; j++)
            {
                if (j % x == 0)
                {
                    Console.WriteLine("Prime: ");
                }
            }
        }
    }
}
