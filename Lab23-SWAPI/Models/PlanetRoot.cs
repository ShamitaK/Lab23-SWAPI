using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab23_SWAPI.Models
{

    public class PlanetRoot
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public PlanetRoot[] results { get; set; }
    }

    public class Planet
    {
        public string Name { get; set; }
        public string Rotation_Period { get; set; }
        public string Orbital_Period { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        public string Surface_Water { get; set; }
        public string Population { get; set; }
        public string[] Residents { get; set; }
        public string[] Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }

}
