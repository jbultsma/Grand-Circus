using System;

namespace FormulaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the area of different shapes");

            double numsOne = GetRectangleArea(10, 5);
            Console.WriteLine(numsOne);

            double numsTwo = GetTriangleArea(4, 3);
            Console.WriteLine(numsTwo);

            double numsThree = PythagreanTheorm( 4, 3);
            Console.WriteLine(numsThree);
        }

        public static double GetRectangleArea(double length, double height)
        {
            return length * height;
        }

        public static double GetTriangleArea(double width, double height)
        {
            return (width * height) / 2; 
        }

        public static double GetTriangleArea(double sideOne, double sideTwo, double sideThree)
        {
            double average = (sideOne + sideTwo + sideThree) / 2;
            double area = average * (average - sideOne) * (average - sideTwo) * (average - sideThree);
            return Math.Sqrt(area);
        }

        public static double PythagreanTheorm(double a, double b)
        {
            double aS = a * a;
            double bS = b * b;
            double result = Math.Sqrt(aS + bS);
            return result;
        }
    }
}
