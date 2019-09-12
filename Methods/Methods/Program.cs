using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = GetUserInput();
            int numTwo = GetUserInput();
            string operation = GetOperation();
            double result = 0;
            

            if (operation == "Addition")
            {
                result = Addition(numOne, numTwo);                
            }

            else if (operation == "Subtraction")
            {
                result = Subtraction(numOne, numTwo);
            }

            else if (operation == "Multiplication")
            { 
                result = Multiplication(numOne, numTwo);
            }

            else if (operation == "Division")
            {
                result = Division(numOne, numTwo);                
            }

            Console.WriteLine("The result is: " + result);

        }

        public static int GetUserInput()
        {
            Console.WriteLine("Hello World! This will be a incredibly simple calculator program.");
            Console.Write("Please input a valid int: ");
            string input = Console.ReadLine();
            int result = int.Parse(input);

            return result;
        }

        public static string GetOperation()
        {
            Console.WriteLine("Please select and operation from the list: (1-4)");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");

            string input = Console.ReadLine();

            switch (input.Trim())
            {
                case "1":
                    return "Addition";
                    break;

                case "2":
                    return "Subtraction";
                    break;

                case "3":
                    return "Multiplication";
                    break;

                case "4":
                    return "Division";
                    break;

                default:
                    Console.WriteLine("I did'nt understand that, let's try again :)");
                    return GetOperation();
                    break;

            }

        }

        public static int Addition (int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public static int Subtraction (int a, int b)
        {
            int diff = a - b;
            return diff;
        }

        public static int Multiplication (int a, int b)
        {
            int prod = a * b;
            return prod;
        }

        public static double Division(double a, double b)
        {
            double div = a / b;
            return div;
        }
    }
}
