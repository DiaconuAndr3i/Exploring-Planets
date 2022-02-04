using ExploringPlanets.Entities;
using ExploringPlanets.ObjectsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringPlanets.Services
{
    public interface IAuthentificationService
    {
        Task Register(RegisterDTO registerDTO);
        Task<LoginResponseDTO> Login(LoginDTO loginDTO);
        Task<string> GenerateToken(User user);
    }
}
