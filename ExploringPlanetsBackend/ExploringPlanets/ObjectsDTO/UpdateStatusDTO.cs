using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringPlanets.ObjectsDTO
{
    public class UpdateStatusDTO
    {
        public string IdPlanet { get; set; }
        public string Status { get; set; }
        public string UserId { get; set; }
    }
}
