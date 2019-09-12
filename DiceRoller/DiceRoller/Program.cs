using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input the number of sides for the dice you will roll: ");
            string input = Console.ReadLine();
            int sides = int.Parse(input);
            Random r = new Random();

            bool rollAgain = true;

            while (rollAgain == true)
            {
                int roll1 = RollDie(sides, r);
                int roll2 = RollDie(sides, r);

                Console.WriteLine(roll1);
                Console.WriteLine(roll2);

                Console.Write("Roll again? (y/n): ");
                string input1 = Console.ReadLine().ToLower().Trim();

                if (input1 == "y")
                {
                    rollAgain = true;
                }

                else
                {
                    rollAgain = false;
                }
            }
            
        }

        public static int RollDie(int sides, Random r)
        {
            int output = r.Next(1, sides + 1);
            return output;
        }
    }
}
