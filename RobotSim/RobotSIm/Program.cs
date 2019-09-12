using System;

namespace RobotSIm
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot wallE = new WallE("Wall-E", 0, 0);
            EVE eve = new EVE("EVE", 1, 0);

            Console.WriteLine(wallE);
            Console.WriteLine(eve);

            wallE.Shutdown();
        }
    }
}
