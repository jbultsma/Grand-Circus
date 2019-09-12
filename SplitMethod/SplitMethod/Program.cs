using System;

namespace SplitMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = "Josh Robert Sam James Jason Tommy Cody";

            string[] data = names.Split(' ');
            foreach (string word in data)
            {
                Console.WriteLine("WORD: " + word);
            }
        }
    }
}
