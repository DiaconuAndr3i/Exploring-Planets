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
    public class CrewService : ICrewService
    {
        private readonly ICrewRepository crewRepository;

        public CrewService(ICrewRepository crewRepository)
        {
            this.crewRepository = crewRepository;
        }

        public async Task AddCrew(RegistrationTeamDTO registrationTeamDTO)
        {
            foreach(var robotId in registrationTeamDTO.RobotIds)
            {
                var crew = new Crew()
                {
                    UserId = registrationTeamDTO.UserId,
                    RobotId = robotId
                };
                await crewRepository.AddCrew(crew);
            }
        }

        public async Task<List<RobotDTO>> GetRobotsAvailableForMission()
        {
            var crewRepo = await crewRepository.GetAllCrew().ToListAsync();
            var robotsRepo = await crewRepository.GetAllRobots().ToListAsync();

            var robots = new List<RobotDTO>();

            
            foreach(var robot in robotsRepo)
            {
                var ok = 0;
                foreach (var crew in crewRepo)
                {
                    if (robot.Id == crew.RobotId)
                        ok = 1;
                }
                if (ok == 0)
                    robots.Add(
                        new RobotDTO
                        {
                            Id = robot.Id,
                            Name = robot.Name
                        });
            }

            return robots;
        }
    }
}
