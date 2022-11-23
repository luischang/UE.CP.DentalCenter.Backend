using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UE.CP.DentalCenter.DOMAIN.Core.DTO_s;
using UE.CP.DentalCenter.DOMAIN.Core.DTOs;
using UE.CP.DentalCenter.DOMAIN.Core.Interface;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;
using UE.CP.DentalCenter.DOMAIN.Infraestructura.Repositories;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Repositories;

namespace UE.CP.DentalCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadController : ControllerBase
    {
        private readonly IEspecialidadRepository especialidadRepository;
        private readonly IMapper mapper;

        public EspecialidadController(IEspecialidadRepository especialidad, IMapper mapper)
        {
            especialidadRepository = especialidad;
            this.mapper = mapper;
        }

        [HttpGet()]
        public async Task<IActionResult> GetEspecialidades()
        {
            var espe = await especialidadRepository.GetEspecialidad();
            //var espeList = mapper.Map<EspecialidadDTO>(espe);
            if (espe == null)
                return NotFound();
            return Ok(espe);
        }


    }
}