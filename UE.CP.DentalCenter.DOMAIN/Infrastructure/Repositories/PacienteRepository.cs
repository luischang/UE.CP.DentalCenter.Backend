using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Data;

namespace UE.CP.DentalCenter.DOMAIN.Infrastructure.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly DentalCenterContext _context;
        public PacienteRepository(DentalCenterContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Paciente>> GetPacientes()
        {
            var pacientes = await _context.Paciente.ToListAsync();
            return pacientes;
        }
        public async Task<IEnumerable<Paciente>> GetPacienteByFrec(bool frec)//DevolverPacientePorBooleanFrecuente
        {
            var paciente = await _context.Paciente.Where(x => x.Frecuente == frec).ToListAsync();
            if (paciente == null)
                throw new Exception("Paciente no encontrado");
            return paciente;
        }

        public async Task<bool> Insert(Paciente paciente)//AñadirPaciente
        {
            await _context.Paciente.AddAsync(paciente);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }
    }
}
