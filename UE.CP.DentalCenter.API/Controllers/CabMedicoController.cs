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
        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
        {
            var medicos = await _cabMedicoRepository.GetMedicos();
            var medicoList = _mapper.Map<List<CabMedicoParaFiltroPacnteDTO>>(medicos);
            if (medicos == null)
                return NotFound();
            return Ok(medicoList);
        }
    }
}
