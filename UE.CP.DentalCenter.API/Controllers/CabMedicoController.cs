using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UE.CP.DentalCenter.DOMAIN.Core.DTOs;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;

namespace UE.CP.DentalCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabMedicoController : ControllerBase
    {
        private readonly ICabMedicoRepository _cabMedicoRepository;
        private readonly IMapper _mapper;

        public CabMedicoController(ICabMedicoRepository cabMedicoRepository, IMapper mapper)
        {
            _cabMedicoRepository = cabMedicoRepository;
            _mapper = mapper;
        }
        //[HttpGet("GetMedicosWithHorarioWithEspecialidad/All")]
        //public async Task<IActionResult> GetMedicosWithHorarioWithEspecialidad()
        //{
        //    var medicos = await _cabMedicoRepository.GetMedicos();
        //    var medicoList = _mapper.Map<List<MedicosConHorarioDTO>>(medicos);
        //    if (medicos == null)
        //        return NotFound();
        //    return Ok(medicoList);
        //}
        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
        {
            var medicos = await _cabMedicoRepository.GetMedicos();
            var medicoList = _mapper.Map<List<CabMedicoDTO>>(medicos);
            if (medicos == null)
                return NotFound();
            return Ok(medicoList);
        }
        [HttpGet("Id/Especialidad")]
        public async Task<IActionResult> GetMedicosByIdEspecialidad(int id)
        {
            var medicos = await _cabMedicoRepository.GetMedicosByIdEspecialidad(id);
            var medicoList = _mapper.Map<List<CabMedicoDTO>>(medicos);
            if (medicos == null)
                return NotFound();
            return Ok(medicoList);
        }
        [HttpGet("Nombre/Especialidad")]
        public async Task<IActionResult> GetMedicosByEspecialidad(string especialidad)
        {
            var medicos = await _cabMedicoRepository.GetMedicosByNombreEspecialidad(especialidad);
            var medicoList = _mapper.Map<List<CabMedicoDTO>>(medicos);
            if (medicos == null)
                return NotFound();
            return Ok(medicoList);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetMedicosById(int id)
        {
            var medicos = await _cabMedicoRepository.GetMedicosById(id);
            var medicoList = _mapper.Map<CabMedicoDTO>(medicos);
            if (medicos == null)
                return NotFound();
            return Ok(medicoList);
        }
    }
}
