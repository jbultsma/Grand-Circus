using System;

namespace GC.Blank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            String userInput = Console.ReadLine();
            int num;
            Int32.TryParse(userInput, out num);

            Console.WriteLine("Ascending");
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("Descending");
            for (int i = num; i >= 0; i--)
            {
                Console.WriteLine(i);                
            }
            Console.WriteLine("Liftoff!");
        }
    }
}
