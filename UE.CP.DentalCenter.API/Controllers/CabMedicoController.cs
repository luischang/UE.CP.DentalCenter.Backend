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
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CabMedicoPostDTO medico)
        {
            CabMedico medico1 = _mapper.Map<CabMedico>(medico);
            var result = await _cabMedicoRepository.InsertCabMedico(medico1);
            if (!result)
                return BadRequest();
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedico(int id)
        {
            var result = await _cabMedicoRepository.Delete(id);
            if (!result)
                return BadRequest("Ocurrió un error al eliminar la receta");

            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CabMedicoDTO cM)
        {
            if (id != cM.IdMedico)
                return BadRequest("No concuerda la informacion del medico");

            var CabM = _mapper.Map<CabMedico>(cM);

            var result = await _cabMedicoRepository.Update(CabM);
            if (!result)
                return BadRequest("Ocurrió un problema al actualizar el medico");
            return Ok(result);

        }
    }
}
