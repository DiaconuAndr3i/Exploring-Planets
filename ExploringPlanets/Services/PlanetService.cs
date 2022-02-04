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
        private readonly ICrewRepository crewRepository;

        public PlanetService(IPlanetRepository planetRepository,
            ICrewRepository crewRepository)
        {
            this.planetRepository = planetRepository;
            this.crewRepository = crewRepository;
        }

        public async Task<List<PlanetDTO>> GetAllPlanets()
        {
            var planets = await planetRepository.GetAllPlanets().ToListAsync();

            var users = await crewRepository.GetAllUsers().ToListAsync();

            var planetsUsers = new List<PlanetDTO>();

            foreach(var planet in planets)
            {
                foreach(var user in users)
                {
                    if (planet.UserId == user.Id)
                    {
                        var obj = new PlanetDTO()
                        {
                            Id = planet.Id,
                            Name = planet.Name,
                            Image = planet.Image,
                            Description = planet.Description,
                            Status = planet.Status,
                            UserId = planet.UserId,
                            FirstNameUser = user.FirstName,
                            LastNameUser = user.LastName
                        };
                        planetsUsers.Add(obj);
                    }
                }
            }

            return planetsUsers;
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
