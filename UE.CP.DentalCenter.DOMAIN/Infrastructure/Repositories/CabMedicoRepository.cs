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
    public class CabMedicoRepository : ICabMedicoRepository
    {
        private readonly DentalCenterContext _context;
        public CabMedicoRepository(DentalCenterContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CabMedico>> GetMedicos()
        {
            var medicos = await _context.CabMedico.ToListAsync();
            return medicos;
        }
    }
}
