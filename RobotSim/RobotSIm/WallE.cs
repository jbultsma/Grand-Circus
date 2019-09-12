using System;
using System.Collections.Generic;
using System.Text;

namespace RobotSIm
{
    class WallE : Robot
    {
        public WallE(string name, int x, int y) : base(name, x, y)  
        {
            Energy = 50;
            moveCost = .5;
            actCost = 1;
        }

        public override void Act()
        {
            Console.WriteLine("Compacting Now!");
            Energy -= actCost;
        }

        public override void Move(int xDistance, int yDistance)
        {
            X += xDistance;
            Y += yDistance;
            Energy -= moveCost;
        }
    }
}
