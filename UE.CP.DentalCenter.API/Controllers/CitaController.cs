using AutoMapper;
using UE.CP.DentalCenter.DOMAIN.Core.DTO_s;
using UE.CP.DentalCenter.DOMAIN.Core.DTOs;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interface;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DentalCentelBacked.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        private readonly ICitaRepository _citaRepository;
        private readonly IMapper mapper;

        public CitaController(ICitaRepository citaRepository, IMapper mapper)
        {
            _citaRepository = citaRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CitaPostDTO cita)
        {
            Cita citaM = mapper.Map<Cita>(cita);
            var result = await _citaRepository.Insert(citaM);
            if (!result)
                return BadRequest();
            return Ok(result);
        }

        [HttpGet("CitaId")]
        public async Task<IActionResult> GetCitaById(int id)
        {
            var cita = await _citaRepository.GetCitaById(id);
            var citaList = mapper.Map<CitaDTO>(cita);
            if (citaList == null)
                return NotFound();
            return Ok(citaList);
        }

        

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CitaDTO cita)
        {
            Cita citaM = mapper.Map<Cita>(cita);
            if (id != citaM.IdCita)
                return BadRequest("No concuerda la informacion de la cita");

            var result = await _citaRepository.Update(citaM);
            if (!result)
                return BadRequest("Ocurrió un problema al actualizar la cita");
            return Ok(result);

        }

        [HttpGet("CitaByPacienteId")]
        public async Task<IActionResult> GetCitaByPacienteById(int id)
        {
            var cita = await _citaRepository.GetListPacienteById(id);
            var citaList = mapper.Map<List<CitaDTO>>(cita);
            if (citaList == null)
                return NotFound();
            return Ok(citaList);
        }


    }
}
