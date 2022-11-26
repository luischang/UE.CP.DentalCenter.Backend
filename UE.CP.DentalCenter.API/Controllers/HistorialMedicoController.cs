using AutoMapper;
using UE.CP.DentalCenter.DOMAIN.Core.DTO_s;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interface;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;
using UE.CP.DentalCenter.DOMAIN.Infraestructura.Repositories;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DentalCentelBacked.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorialMedicoController : ControllerBase
    {
        private readonly IHistoriaMedicaRepository _historiaMedRepository;
        private readonly IMapper mapper;

        public HistorialMedicoController(IHistoriaMedicaRepository historiaMedRepository, IMapper mapper)
        {
            _historiaMedRepository = historiaMedRepository;
            this.mapper = mapper;
        }


        [HttpPost("Cabecera")]
        public async Task<IActionResult> CrearCabHistoriaM(CabeceraHistoriaCliPostDTO cabeceraH)
        {
            CabHistoriaMedica creceta = mapper.Map<CabHistoriaMedica>(cabeceraH);
            var result = await _historiaMedRepository.InsertCabHistoriaM(creceta);

            if (!result)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpPost("Detalle")]
        public async Task<IActionResult> CrearDetHistoriaM(DetHistoriaPostDTO detH)
        {
            DetHistoriaMedica detHis = mapper.Map<DetHistoriaMedica>(detH);
            var result = await _historiaMedRepository.InsertDetHistoriaM(detHis);

            if (!result)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] HistoriaMedicaDTO hm)
        {
            DetHistoriaMedica detH = mapper.Map<DetHistoriaMedica>(hm);
            if (id != detH.IdDetHistoriaMedica)
                return BadRequest("No concuerda la informacion de la cita");

            var result = await _historiaMedRepository.Update(detH);
            if (!result)
                return BadRequest("Ocurrió un problema al actualizar la cita");
            return Ok(result);

        }

        [HttpGet("idTramiento")]
        public async Task<IActionResult> GetDetallByTratamiento(int id)
        {
            var DetHistoria = await _historiaMedRepository.GetHisMedicaWithIdTramiento(id);


            var DetalleHistoriaDTO = mapper.Map<List<DetHistoTratamientoGetDTO>>(DetHistoria);
            if (DetalleHistoriaDTO == null)
                return NotFound();
            return Ok(DetalleHistoriaDTO);
        }

        [HttpGet("NombreTramiento")]
        public async Task<IActionResult> GetDetallByTratamiento(string tr)
        {
            var DetHistoria = await _historiaMedRepository.GetHisMedicaNombreTramiento(tr);


            var DetalleHistoriaDTO = mapper.Map<List<DetHistoTratamientoGetDTO>>(DetHistoria);
            if (DetalleHistoriaDTO == null)
                return NotFound();
            return Ok(DetalleHistoriaDTO);
        }
        [HttpGet("idMedico")]
        public async Task<IActionResult> GetDetallByIdMedico(int id)
        {
            var DetHistoria = await _historiaMedRepository.GetHisMedicaMedicoID(id);


            var DetalleHistoriaDTO = mapper.Map<List<DetHistoTratamientoGetDTO>>(DetHistoria);
            if (DetalleHistoriaDTO == null)
                return NotFound();
            return Ok(DetalleHistoriaDTO);
        }

        [HttpGet("CabHistoria/IdPaciente")]
        public async Task<IActionResult> GetCabHistoriaByIdPaciente(int id)
        {
            var Cab_Historia = await _historiaMedRepository.GetCabHistoriaMedicaByIdPaciente(id);
            


            var Cab_HistoriaDTO = mapper.Map<List<HistoriaMedicaDTO>>(Cab_Historia);
            if (Cab_HistoriaDTO == null)
                return NotFound();
            return Ok(Cab_HistoriaDTO);
        }

        [HttpGet("CabHistoria/Id")]
        public async Task<IActionResult> GetCabHistoriaById(int id)
        {
            var Cab_Historia = await _historiaMedRepository.GetCabHistoriaMedicaById(id);

            var Cab_HistoriaDTO = mapper.Map<List<HistoriaMedicaDTO>>(Cab_Historia);
            if (Cab_HistoriaDTO == null)
                return NotFound();
            return Ok(Cab_HistoriaDTO);
        }


        [HttpGet("HistoriaMedica/IdPaciente")]
        public async Task<IActionResult> GetHistoriaByIdPaciente(int id)
        {
            var CabHistoria = await _historiaMedRepository.GetCabHistoriaMedicaByIdPaciente(id);
            List<DetHistoriaMedica> detHistoria = new List<DetHistoriaMedica>();
            foreach(var xtem in CabHistoria)
            {
                detHistoria.AddRange(await _historiaMedRepository.GetHistoriaMedicaByIdcab(xtem.IdHistoriaMedica));
            }

            var HistoriaDTO = mapper.Map<List<DetHistoTratamientoGetDTO>>(detHistoria);
            if (HistoriaDTO == null)
                return NotFound();
            return Ok(HistoriaDTO);
        }

    }
}
