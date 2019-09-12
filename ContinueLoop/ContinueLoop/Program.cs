using System;

namespace ContinueLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //keep the is bool statement
            bool isKeepGoing = true;
            //yoooooooooo bro
            while (isKeepGoing == true)
            {
                Console.Write("Please input two numbers: ");
                string inputOne = Console.ReadLine();
                int numOne = int.Parse(inputOne);

                string inputTwo = Console.ReadLine();
                int numTwo = int.Parse(inputTwo);

                Console.Write("Equals: ");
                Console.WriteLine(numOne + numTwo);

                bool isGoodInput = false;
                while (isGoodInput == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Would you like to continue? y/n");
                    string answer = Console.ReadLine();

                    if (answer == "y")
                    {
                        break;
                    }

                    else if (answer == "n")
                    {
                        isKeepGoing = false;
                        Console.WriteLine("Goodbye! Thanks for using our app.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Hey i did not understand that, please try again!");
                    }
                }
            }
        }
    }
}