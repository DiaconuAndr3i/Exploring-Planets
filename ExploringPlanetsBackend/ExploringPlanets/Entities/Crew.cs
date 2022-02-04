using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringPlanets.Entities
{
    public class Crew
    {
        public string UserId { get; set; }
        public string RobotId { get; set; }
        public virtual User User { get; set; }
        public virtual Robot Robot { get; set; }
    }
}
