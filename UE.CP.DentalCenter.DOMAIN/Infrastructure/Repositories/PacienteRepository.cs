using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Data;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Repositories;

namespace UE.CP.DentalCenter.DOMAIN.Infrastructure.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly Data.DentalCenterContext _context;
        public PacienteRepository(DentalCenterContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Paciente>> GetPacientes()
        {
            var paciente = await _context.Paciente.ToListAsync();
            return paciente;
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

        

        public async Task<Paciente> getPacienteByNombre(string nombre)
        {
            var paciente = await _context.Paciente.Where(X => X.Nombre == nombre).FirstOrDefaultAsync();
            /*if (customer == null)
            {
                throw new Exception("Customer not found");
            }*/
            return paciente;
        }

        public async Task<Paciente> getPacienteByFecha(DateTime fecha)
        {
            var paciente = await _context.Paciente.Where(X => X.FechaDeNac == fecha).FirstOrDefaultAsync();
            /*if (customer == null)
            {
                throw new Exception("Customer not found");
            }*/
            return paciente;
        }

    }
}
