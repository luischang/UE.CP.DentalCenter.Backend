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
    public class TratamientoController : ControllerBase
    {
        private readonly ITratamientoRepository _tratamientoRepository;//Injección del repositorio en el controller para usarse
        private readonly IMapper mapper;
        public TratamientoController(ITratamientoRepository tratamientoRepository, IMapper mapper)
        {
            _tratamientoRepository = tratamientoRepository;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TratamientoPostDTO tratamiento)
        {
            Tratamiento tratamiento1 = mapper.Map<Tratamiento>(tratamiento);
           var result =  await _tratamientoRepository.Insert(tratamiento1);
            if (!result)
                return BadRequest();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTratamientos()
        {

            var tratamiento = await _tratamientoRepository.GetTratamientos();

            var tratamientoList = mapper.Map<List<TratamientoDTO>>(tratamiento);


            return Ok(tratamientoList);
        }
    }
}
