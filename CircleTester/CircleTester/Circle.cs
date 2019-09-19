using System;
using System.Collections.Generic;
using System.Text;

namespace CircleTester
{
    class Circle
    {
        public double radius;
        public double GetRadius()
        {


            get
            {
                Console.Write("Please enter the radius: ");
                string input = Console.ReadLine().Trim();
                radius = double.Parse(input);
            }

            set
            {
                Console.WriteLine("Invalid Input, please try again!");
                GetRadius();
            }

            return radius;
        }
        public Circle (double radius)
        {
            this.radius = Radius;
        }

        public double CalculateCircumfrence()
        {
            double circumfrence = (2 * Math.PI * Radius);

            return circumfrence;
        }

    }
}
