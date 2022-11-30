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
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IMapper _mapper;
        public PacienteController(IPacienteRepository pacienteRepository, IMapper mapper)
        {
            _pacienteRepository = pacienteRepository;
            _mapper = mapper;
        }
        [HttpGet("frecuente")]
        public async Task<IActionResult> GetPacienteByFrec(bool frec)
        {
            var pacientes = await _pacienteRepository.GetPacienteByFrec(frec);
            var pacienteList = _mapper.Map<List<PacienteFrecuenteDTO>>(pacientes);
            if (pacientes == null)
                return NotFound();
            return Ok(pacienteList);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]PacientePostDTO paciente)
        {
            Paciente pacienteF = _mapper.Map<Paciente>(paciente);

            var result = await _pacienteRepository.Insert(pacienteF);
            
            if(!result)
                return BadRequest();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var paciente = await _pacienteRepository.GetPacientes();

            var pacienteList = _mapper.Map<List<PacienteDTO>>(paciente);


            return Ok(pacienteList);
        }

        //[HttpGet("{nombre}")]
        //public async Task<IActionResult> GetPacienteNombre(string nombre)
        //{
        //    var paciente = await _pacienteRepository.getPacienteByNombre(nombre);
        //    if (paciente == null)
        //    {
        //        return NotFound();
        //    }
        //    var pacienteList = _mapper.Map<PacienteDTO>(paciente);
        //    return Ok(pacienteList);
        //}


        [HttpGet("Fecha")]
        public async Task<IActionResult> GetPacienteByFech(DateTime fecha)
        {
            var pacientes = await _pacienteRepository.getPacienteByFecha(fecha);
            var pacienteL = _mapper.Map<PacienteDTO>(pacientes);
            return Ok(pacienteL);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetPacientesById(int id)
        {
            var pacientes = await _pacienteRepository.getPacienteById(id);
            var pacienteList = _mapper.Map<PacienteDTO>(pacientes);
            if (pacientes == null)
                return NotFound();
            return Ok(pacienteList);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] PacienteDTO ente)
        {
            if (id != ente.IdPaciente)
                return BadRequest("No concuerda la informacion del paciente");

            var pac = _mapper.Map<Paciente>(ente);

            var result = await _pacienteRepository.Update(pac);
            if (!result)
                return BadRequest("Ocurrió un problema al actualizar el paciente");
            return Ok(result);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _pacienteRepository.Delete(id);
            if (!result)
                return BadRequest("Ocurrió un error al eliminar el paciente");

            return Ok(result);
        }

    }
}
