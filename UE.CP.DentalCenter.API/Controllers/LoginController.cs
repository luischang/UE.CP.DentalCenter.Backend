using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UE.CP.DentalCenter.DOMAIN.Core.DTOs;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Repositories;

namespace UE.CP.DentalCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _loginRepository;
        private readonly IMapper _mapper;
        public LoginController(ILoginRepository loginRepository, IMapper mapper)
        {
            _loginRepository = loginRepository;
            _mapper = mapper;
        }
        [HttpPost("crear")]
        public async Task<IActionResult> Create([FromBody] LoginPacientePostDTO login)
        {
            Login loginF = _mapper.Map<Login>(login);

            var result = await _loginRepository.Insert(loginF);

            if (!result)
                return BadRequest();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> GetLogin([FromBody] LoginData log)
        {
            var loginDTO = await _loginRepository.GetLogin(log.Usuario, log.Contraseña);
            if (loginDTO == null)
                return NotFound();
            else
            {
                if (loginDTO.Tipo == "Medico")
                {
                    var login = _mapper.Map<LoginGetShowDTO>(loginDTO);
                    return Ok(login);
                }
                else if (loginDTO.Tipo == "Paciente")
                {
                    var login = _mapper.Map<LoginGetPShowDTO>(loginDTO);

                    return Ok(login);
                }
                else if (loginDTO.Tipo == "Administrador")
                {
                    var login = _mapper.Map<LoginGetAShowDTO>(loginDTO);

                    return Ok(login);
                }
                else
                {
                    return Ok(loginDTO);
                }
            }
        }

    }
}
