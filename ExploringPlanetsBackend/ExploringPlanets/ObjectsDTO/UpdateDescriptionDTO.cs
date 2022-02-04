using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringPlanets.ObjectsDTO
{
    public class UpdateDescriptionDTO
    {
        public string IdPlanet { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
    }
}
