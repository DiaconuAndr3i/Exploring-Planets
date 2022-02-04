using ExploringPlanets.ObjectsDTO;
using ExploringPlanets.Services;
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
    public class AuthentificationController : ControllerBase
    {
        private readonly IAuthentificationService authentificationService;

        public AuthentificationController(IAuthentificationService authentificationService)
        {
            this.authentificationService = authentificationService;
        }

        [HttpPost("/login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            try
            {
                var responseLogin = await authentificationService.Login(loginDTO);

                if (responseLogin != null)
                    return Ok(responseLogin);
                else
                    return BadRequest();
            }

            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("/register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO registerDTO)
        {
            await authentificationService.Register(registerDTO);

            return Ok();
        }
    }
}
