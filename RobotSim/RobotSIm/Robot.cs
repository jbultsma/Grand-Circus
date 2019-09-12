using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RobotSIm
{
    class Robot
    {
        protected string Name;
        protected int X;
        protected int Y;
        protected double Energy = 100;
        protected double moveCost = 1;
        protected double actCost = 5;

        public Robot(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{Name} ({X},{Y}) {Energy}";
        }

        public virtual void Move(int xDistance, int yDistance)
        {
            
        }

        public virtual void Act()
        {

        }

        public void Recharge(int energy)
        {
            Energy += energy;
        }

        public void Shutdown()
        {
            Console.WriteLine("Initiate Shutdown Sequence");
            Thread.Sleep(5000);
            Console.WriteLine("Shutdown complete");
        }
    }
}
