using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    public class Liger : Animal
    {
        public Liger(string name) : base(name)
        {

        }

        public override string GetFood()
        {
            return "Gimmee your tots!";
        }

        public override void PrintFood()
        {
            Console.WriteLine($"The Liger {name} say's {GetFood()}\n");
        }
    }
}
