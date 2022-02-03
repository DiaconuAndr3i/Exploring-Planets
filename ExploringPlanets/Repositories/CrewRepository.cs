using ExploringPlanets.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringPlanets.Repositories
{
    public class CrewRepository : ICrewRepository
    {
        private readonly Context db;

        public CrewRepository(Context db)
        {
            this.db = db;
        }

        public async Task AddCrew(Crew crew)
        {
            await db.AddAsync(crew);

            await SaveChanges();
        }

        public IQueryable<Crew> GetAllCrew()
        {
            var crew = db.Crews;

            return crew;
        }

        public IQueryable<Robot> GetAllRobots()
        {
            var robots = db.Robots;

            return robots;
        }

        public async Task SaveChanges()
        {
            await db.SaveChangesAsync();
        }
    }
}
