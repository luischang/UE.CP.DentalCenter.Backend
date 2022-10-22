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
    public class HorarioDisponibleRepository : IHorarioDisponibleRepository
    {
        private readonly Data.DentalCenterContext _context;
        public HorarioDisponibleRepository(Data.DentalCenterContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<HorarioDisponible>> GetHorarioDisponibleById(int id)
        {
            var horarios = await _context.HorarioDisponible.Where(x => x.IdMedico == id).ToListAsync();
            if (horarios == null)
                throw new Exception("Horarios no encontrados");
            return horarios;
        }
    }
}
