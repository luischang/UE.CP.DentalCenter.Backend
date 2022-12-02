using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UE.CP.DentalCenter.DOMAIN.Core.DTOs;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;

namespace UE.CP.DentalCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicamentoController : ControllerBase
    {
        private readonly IMedicamentoRepository medicamentoRepository;
        private readonly IMapper _mapper;
        public MedicamentoController(IMedicamentoRepository medicamento, IMapper mapper)
        {
            medicamentoRepository = medicamento;
            _mapper = mapper;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var med = await medicamentoRepository.GetMedicamentoss();

            var medL = _mapper.Map<List<MedicamentoDTO>>(med);


            return Ok(medL);
        }
    }

    
}
