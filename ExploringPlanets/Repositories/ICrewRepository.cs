using ExploringPlanets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringPlanets.Repositories
{
    public interface ICrewRepository
    {
        public IQueryable<Robot> GetAllRobots();
        public IQueryable<Crew> GetAllCrew();
        Task AddCrew(Crew crew);
        Task SaveChanges();
    }
}
