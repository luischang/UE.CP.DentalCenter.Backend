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
    public class FacturaRepository: IFacturaRepository
    {
        private readonly DentalCenterContext _context;
        public FacturaRepository(DentalCenterContext context)
        {
            _context = context;
        }
        public async Task<bool> Insert(DetFactura detFactura)
        {
            await _context.DetFactura.AddAsync(detFactura);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }
        public async Task<bool> InsertCabF(CabFactura cabF)
        {
            await _context.CabFactura.AddAsync(cabF);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }
    }
}
