using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UE.CP.DentalCenter.DOMAIN.Core.DTOs;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;

namespace UE.CP.DentalCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IMapper _mapper;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio,
                                 IMapper mapper)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _mapper = mapper;
        }

        [HttpPost("Signup")]
        public async Task<IActionResult> Signup([FromBody] UsuarioRegisterDTO usuarioRegisterDTO)
        {
            var usuario = _mapper.Map<Usuario>(usuarioRegisterDTO);
            usuario.Estado = "A";
            var result = await _usuarioRepositorio.SignUp(usuario);
            if (result < 0)
                return BadRequest(new { Status = false, Data = new { UsuarioId = result } });

            return Ok(new { Status = true, Data = new { UsuarioId = result } });
        }

        [HttpPost("Signin")]
        public async Task<IActionResult> SignIn([FromBody] UsuarioSingInDTO usuarioSingInDTO)
        {
            if (usuarioSingInDTO.NumeroDocumento == null ||
                string.IsNullOrEmpty(usuarioSingInDTO.Contrasena) ||
                string.IsNullOrEmpty(usuarioSingInDTO.TipoUsuario))
                return BadRequest(new { Status = false, Data = "Ingrese el numero de documento, contraseña y tipo de usuario" });
            var result = await _usuarioRepositorio
                            .SignIn((int)usuarioSingInDTO.NumeroDocumento
                            , usuarioSingInDTO.Contrasena
                            , usuarioSingInDTO.TipoUsuario);
            if (result == null)
                return NotFound(new { Status = false, Data = "Numero de documento o Contraseña inválida" });
            var usuario = _mapper.Map<UsuarioDTO>(result);
            return Ok(new { Status = true, Data = usuario });

        }

    }
}
