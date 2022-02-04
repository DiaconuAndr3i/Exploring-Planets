using ExploringPlanets.ObjectsDTO;
using ExploringPlanets.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringPlanets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionsController : ControllerBase
    {
        private readonly IPlanetService planetService;
        private readonly ICrewService crewService;

        public ActionsController(IPlanetService planetService, ICrewService crewService)
        {
            this.planetService = planetService;
            this.crewService = crewService;
        }

        [HttpGet("/getAllPlanets")]
        [Authorize(Policy = "Captain")]
        public async Task<IActionResult> GetAllPlanets()
        {
            var planets = await planetService.GetAllPlanets();

            return Ok(planets);
        }

        [HttpPut("/updateStatus")]
        [Authorize(Policy = "Captain")]
        public async Task<IActionResult> UpdateStatus([FromBody] UpdateStatusDTO updateStatusDTO)
        {
            await planetService.UpdateStatus(updateStatusDTO);

            return Ok();
        }

        [HttpPut("/updateDescription")]
        [Authorize(Policy = "Captain")]
        public async Task<IActionResult> UpdateDescription([FromBody] UpdateDescriptionDTO updateDescriptionDTO)
        {
            await planetService.UpdateDescription(updateDescriptionDTO);

            return Ok();
        }

        [HttpGet("/availableRobotsForMission")]
        public async Task<IActionResult> AvailableRobotsForMission()
        {
            var robots = await crewService.GetRobotsAvailableForMission();

            return Ok(robots);
        }

        [HttpPost("/createCrew")]
        public async Task<IActionResult> CreateCrew([FromBody] RegistrationTeamDTO registrationTeamDTO)
        {
            await crewService.AddCrew(registrationTeamDTO);

            return Ok();
        }

    }
}
