using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI.Models
{
    public class Planets
    {
        public string name { get; set; }
       
        public string gravity { get; set; }
        public string terrain { get; set; }
        public int population { get; set; }

        public Planets()
        {

        }

        public Planets(JToken t)
        {
            this.name = t["name"].ToString(); 
            this.gravity = t["gravity"].ToString();
            this.terrain = t["terrain"].ToString();
            this.population = int.Parse(t["population"].ToString());
        }
    }
}
