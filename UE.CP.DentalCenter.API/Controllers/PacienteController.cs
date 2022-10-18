﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;

namespace UE.CP.DentalCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;
        public PacienteController(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }
        [HttpGet("{frecuente}")]
        public async Task<IActionResult> GetPacienteByFrec()
        {
            var pacientes = await _pacienteRepository.GetPacientes();
            return Ok(pacientes);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]Paciente paciente)
        {
            var result = await _pacienteRepository.Insert(paciente);
            if(!result)
                return BadRequest();
            return Ok(result);
        }
    }
}