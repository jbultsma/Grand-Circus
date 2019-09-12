using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects2Multiple
{
    class FoodSource
    {
        public string name { get; }
        public int supply { get; }

        public FoodSource(string name, int supply)
        {
            this.name = name;
            this.supply = supply;
        }
    }
}

