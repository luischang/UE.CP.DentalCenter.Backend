using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;

namespace UE.CP.DentalCenter.DOMAIN.Infrastructure.Repositories
{
    public class EspecialidadRepository:IEspecialidadRepository
    {
        private readonly Data.DentalCenterContext _context;
        public EspecialidadRepository(Data.DentalCenterContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Especialidad>> GetEspecialidad()
        {
            var especialidades = await _context.Especialidad.ToListAsync();
            return especialidades;
        }
    }
}
