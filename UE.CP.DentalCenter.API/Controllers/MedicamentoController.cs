using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UE.CP.DentalCenter.DOMAIN.Core.DTOs;
using UE.CP.DentalCenter.DOMAIN.Core.Interface;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Repositories;

namespace UE.CP.DentalCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicamentoController : ControllerBase
    {
        private readonly IMedicamentoRepository _medRepository;
        private readonly IMapper mapper;

        public MedicamentoController(IMedicamentoRepository medicamento, IMapper mapper)
        {
            _medRepository = medicamento;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var med = await _medRepository.GetMedicamentoss();

            var medlis = mapper.Map<List<MedicamentoDTO>>(med);


            return Ok(medlis);
        }

    }
}
