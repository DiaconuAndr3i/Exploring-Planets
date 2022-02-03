using ExploringPlanets.Entities;
using ExploringPlanets.ObjectsDTO;
using ExploringPlanets.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringPlanets.Services
{
    public class PlanetService : IPlanetService
    {
        private readonly IPlanetRepository planetRepository;

        public PlanetService(IPlanetRepository planetRepository)
        {
            this.planetRepository = planetRepository;
        }

        public async Task<List<Planet>> GetAllPlanets()
        {
            var planets = await planetRepository.GetAllPlanets().ToListAsync();

            return planets;
        }

        public async Task UpdateDescription(UpdateDescriptionDTO updateDescriptionDTO)
        {
            var planet = await planetRepository.GetAllPlanets()
                .Where(x => x.Id == updateDescriptionDTO.IdPlanet).FirstOrDefaultAsync();

            planet.Description = updateDescriptionDTO.Description;

            planet.UserId = updateDescriptionDTO.UserId;

            await planetRepository.SaveChanges();
        }

        public async Task UpdateStatus(UpdateStatusDTO updateStatusDTO)
        {
            var planet = await planetRepository.GetAllPlanets()
                .Where(x => x.Id == updateStatusDTO.IdPlanet).FirstOrDefaultAsync();

            planet.Status = updateStatusDTO.Status;

            planet.UserId = updateStatusDTO.UserId;

            await planetRepository.SaveChanges();
        }

    }
}
