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
    public class TratamientoRepository : ITratamientoRepository
    {
        private readonly Data.DentalCenterContext _context;
        public TratamientoRepository(Data.DentalCenterContext context)
        {
            _context = context;
        }
        public async Task<bool> Insert(Tratamiento tratamiento)
        {
            await _context.Tratamiento.AddAsync(tratamiento);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }
        public async Task<IEnumerable<Tratamiento>> GetTratamientos()
        {
            var tratamientos = await _context.Tratamiento.ToListAsync();
            return tratamientos;
        }
        public async Task<bool> Update(Tratamiento tratamiento)
        {
            _context.Tratamiento.Update(tratamiento);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }
        public async Task<bool> Delete(int id)
        {
            var tratamiento = await _context.Tratamiento.FindAsync(id);
            if (tratamiento == null)
                return false;

            _context.Tratamiento.Remove(tratamiento);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }
    }
}