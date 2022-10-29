using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UE.CP.DentalCenter.DOMAIN.Core.DTO_s;
using UE.CP.DentalCenter.DOMAIN.Core.DTOs;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Repositories;

namespace UE.CP.DentalCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorarioDisponibleController : ControllerBase
    {
        private readonly IHorarioDisponibleRepository _horarioDisponibleRepository;
        private readonly IMapper _mapper;

        public HorarioDisponibleController(IHorarioDisponibleRepository horarioDisponibleRepository, IMapper mapper)
        {
            _horarioDisponibleRepository = horarioDisponibleRepository;
            _mapper = mapper;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHorarioDisponibleById(int id)
        {
            var horarios = await _horarioDisponibleRepository.GetHorarioDisponibleById(id);
            var horariosList = _mapper.Map<List<HorarioDisponibleDTO>>(horarios);
            if (horarios == null)
                return NotFound();
            return Ok(horariosList);
        }
        [HttpGet("Doctorid")]
        public async Task<IActionResult> GetHorarioDisponibleByDoctorId(int id)
        {
            var horarios = await _horarioDisponibleRepository.GetHorarioDisponibleByDoctorId(id);
            var horariosList = _mapper.Map<List<HorarioDisponibleDTO>>(horarios);
            if (horarios == null)
                return NotFound();
            return Ok(horariosList);
        }

        [HttpGet("NombreMedico")]
        public async Task<IActionResult> GetHorarioMedicoByNombre(string tr)
        {
            var horarios = await _horarioDisponibleRepository.GetHorarioDisponibleByDoctorName(tr);


            var ListHorarios = _mapper.Map<List<HorarioDisponibleDTO>>(horarios);
            if (ListHorarios == null)
                return NotFound();
            return Ok(ListHorarios);
        }
    }
}
