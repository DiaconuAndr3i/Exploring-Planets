using ExploringPlanets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringPlanets.Repositories
{
    public interface IPlanetRepository
    {
        public IQueryable<Planet> GetAllPlanets();
        Task SaveChanges();
    }
}
