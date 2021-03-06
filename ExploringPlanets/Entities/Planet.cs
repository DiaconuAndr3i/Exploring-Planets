using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringPlanets.Entities
{
    public class Planet
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
