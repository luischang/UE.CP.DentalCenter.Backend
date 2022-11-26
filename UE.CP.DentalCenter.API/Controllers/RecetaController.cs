using AutoMapper;
using UE.CP.DentalCenter.DOMAIN.Core.DTO_s;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interface;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;
using UE.CP.DentalCenter.DOMAIN.Infraestructura.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UE.CP.DentalCenter.DOMAIN.Core.DTOs;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Repositories;

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

        [HttpGet("CabReceta")]
        public async Task<IActionResult> GetCabReceta()
        {

            var Cab_receta = await _recetaRepository.GetCabRecetas();

            var Cab_recetaList = mapper.Map<List<CabeceraRecetaDTO>>(Cab_receta);

            return Ok(Cab_recetaList);


        }

        [HttpGet("Receta")]
        public async Task<IActionResult> GetRecetas()
        {

            var receta = await _recetaRepository.GetRecetas();

            var recetaList = mapper.Map<List<RecetaDTO>>(receta);

            return Ok(recetaList);


        }

        [HttpDelete("Receta")]
        public async Task<IActionResult> DeleteReceta(int id)
        {
            var result = await _recetaRepository.DeleteReceta(id);
            if (!result)
                return BadRequest("Ocurrió un error al eliminar la receta");

            return Ok(result);
        }

    }
    }
