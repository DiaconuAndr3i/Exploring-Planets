using ExploringPlanets.Entities;
using ExploringPlanets.ObjectsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringPlanets.Services
{
    public interface ICrewService
    {
        Task<List<Robot>> GetRobotsAvailableForMission();
        Task AddCrew(RegistrationTeamDTO registrationTeamDTO);
    }
}
