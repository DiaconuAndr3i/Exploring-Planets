using ExploringPlanets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringPlanets.Repositories
{
    public class PlanetRepository : IPlanetRepository
    {
        private readonly Context db;

        public PlanetRepository(Context db)
        {
            this.db = db;
        }

        public IQueryable<Planet> GetAllPlanets()
        {
            var planets = db.Planets;

            return planets;
        }

        public async Task SaveChanges()
        {
            await db.SaveChangesAsync();
        }
    }
}
