using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringPlanets.Entities
{
    public class Robot
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Crew> Crews { get; set; }
    }
}
