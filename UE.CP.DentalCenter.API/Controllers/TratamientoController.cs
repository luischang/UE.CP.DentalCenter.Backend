using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;

namespace UE.CP.DentalCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TratamientoController : ControllerBase
    {
        private readonly ITratamientoRepository _tratamientoRepository;//Injección del repositorio en el controller para usarse

        public TratamientoController(ITratamientoRepository tratamientoRepository)
        {
            _tratamientoRepository = tratamientoRepository;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Tratamiento tratamiento)
        {
           var result =  await _tratamientoRepository.Insert(tratamiento);
            if (!result)
                return BadRequest();
            return Ok(result);

        }
    }
}
