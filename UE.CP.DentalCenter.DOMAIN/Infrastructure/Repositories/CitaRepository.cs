using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Data;

namespace UE.CP.DentalCenter.DOMAIN.Infraestructura.Repositories
{
    public class CitaRepository : ICitaRepository
    {
        private readonly DentalCenterContext _context;

        public CitaRepository(DentalCenterContext context)
        {
            _context = context;
        }

        public async Task<bool> Insert(Cita cita)
        {
            await _context.Cita.AddAsync(cita);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }

        public async Task<Cita> GetCitaById(int id)
        {
            var cita = await _context.Cita.Where(x => x.IdCita == id).FirstOrDefaultAsync();
            if (cita == null)
                throw new Exception("Cita not found");
            return cita;
        }

        public async Task<Cita> GetPacienteById(int id)
        {
            var cita = await _context.Cita.Where(x => x.IdPaciente == id).FirstOrDefaultAsync();
            if (cita == null)
                throw new Exception("Cita not found");
            return cita;
        }

        public async Task<bool> Update(Cita cita)
        {
            _context.Cita.Update(cita);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;

        }
        public async Task<IEnumerable<Cita>>GetListPacienteById(int id)
        {
            var cita = await _context.Cita.Where(x => x.IdPaciente == id).ToListAsync();
            if (cita == null)
                throw new Exception("Cita not found");
            return cita;
        }

        public async Task<IEnumerable<Cita>> GetListMedicoById(int id)
        {
            var cita = await _context.Cita.Where(x => x.IdMedico == id).ToListAsync();
            if (cita == null)
                throw new Exception("Cita not found");
            return cita;
        }


    }
}
