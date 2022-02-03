using ExploringPlanets.Entities;
using ExploringPlanets.ObjectsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringPlanets.Services
{
    public interface IPlanetService
    {
        Task<List<Planet>> GetAllPlanets();
        Task UpdateStatus(UpdateStatusDTO updateStatusDTO);
        Task UpdateDescription(UpdateDescriptionDTO updateDescriptionDTO);
    }
}
