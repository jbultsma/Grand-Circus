using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI.Models
{
    public class Vehicles
    {
        public string name { get; set; }
        public string model { get; set; }
        public string maxSpeed { get; set; }
        public string starshipClass { get; set; }

        public Vehicles()
        {

        }

        public Vehicles(JToken t)
        {
            this.name = t["name"].ToString();
            this.model = t["model"].ToString();
            this.maxSpeed = t["max_atmosphering_speed"].ToString();
            this.starshipClass = t["starship_class"].ToString();
        }
    }

    
}
