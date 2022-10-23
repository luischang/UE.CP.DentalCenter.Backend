using AutoMapper;
using UE.CP.DentalCenter.DOMAIN.Core.DTO_s;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interface;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;
using UE.CP.DentalCenter.DOMAIN.Infraestructura.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DentalCentelBacked.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecetaController : ControllerBase
    {
        private readonly IRecetaRepository _recetaRepository;
        private readonly IMapper mapper;

        public RecetaController(IRecetaRepository recetaRepository, IMapper mapper)
        {
            _recetaRepository = recetaRepository;
            this.mapper = mapper;
        }


        [HttpPost("CabReceta")]
        public async Task<IActionResult> CrearCabReceta(CabeceraRecetaPostDTO cabrecetaN)
        {
            CabRecetaMedica creceta = mapper.Map<CabRecetaMedica>(cabrecetaN);
            var result = await _recetaRepository.InsertCabReceta(creceta);

            if (!result)
            {
                return BadRequest();
            }
            return Ok(result);
        }
        [HttpPost("DetReceta")]
        public async Task<IActionResult> CrearReceta(RecetaPostDTO recetaN)
        {
            DetRecetaMedica receta = mapper.Map<DetRecetaMedica>(recetaN);
            var result = await _recetaRepository.InsertReceta(receta);

            if (!result)
            {
                return BadRequest();
            }
            return Ok(result);
        }



    }
}
