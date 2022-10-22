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
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaRepository _facturaRepository;
        private readonly IMapper _mapper;
        public FacturaController(IFacturaRepository facturaRepository, IMapper mapper)
        {
            _facturaRepository = facturaRepository;
            _mapper = mapper;
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] FacturaDTO fact)
        {
            DetFactura detFactura = _mapper.Map<DetFactura>(fact);

            var result = await _facturaRepository.Insert(detFactura);

            if (!result)
                return BadRequest();
            return Ok(result);
        }

        [HttpPost("CabFactura")]
        public async Task<IActionResult> CreateCabF([FromBody] CabFacturaDTO Cfact)
        {
            CabFactura cabFAc = _mapper.Map<CabFactura>(Cfact);

            var result = await _facturaRepository.InsertCabF(cabFAc);

            if (!result)
                return BadRequest();
            return Ok(result);
        }



    }
}
