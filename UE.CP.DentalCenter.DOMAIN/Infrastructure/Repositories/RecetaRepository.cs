
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Data;

using UE.CP.DentalCenter.DOMAIN.Core.Interface;

namespace UE.CP.DentalCenter.DOMAIN.Infraestructura.Repositories
{
    public class RecetaRepository: IRecetaRepository
    {
        private readonly DentalCenterContext _context;
        public RecetaRepository(DentalCenterContext context)
        {
            _context = context;
        }

        public async Task<bool> InsertReceta(DetRecetaMedica receta)//AñadirReceta
        {
            await _context.DetRecetaMedica.AddAsync(receta);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }
        public async Task<bool> InsertCabReceta(CabRecetaMedica cabR)//AñadirCabReceta
        {
            await _context.CabRecetaMedica.AddAsync(cabR);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }

        public async Task<IEnumerable<DetRecetaMedica>> GetRecetas()
        {
            var recetaMedicas = await _context.DetRecetaMedica.ToListAsync();
            return recetaMedicas;
        }
        public async Task<IEnumerable<CabRecetaMedica>> GetCabRecetas()
        {
            var Cab_recetaMedicas = await _context.CabRecetaMedica.ToListAsync();
            return Cab_recetaMedicas;
        }


        public async Task<IEnumerable<DetRecetaMedica>> GetRecetasByIdCab(int id)
        {
            var recetaMedicas = await _context.DetRecetaMedica.ToListAsync();
            List<DetRecetaMedica> listDet = new List<DetRecetaMedica>();
            foreach(var item in recetaMedicas)
            {
                if (item.IdRecetaMedica == id)
                {
                    listDet.Add(item);
                }
            }
            
            return listDet;
        }

        public async Task<CabRecetaMedica> GetUltimaCabReceta()
        {
            var Cab_recetaMedica = await _context.CabRecetaMedica.OrderBy(x=>x.IdRecetaMedica).LastOrDefaultAsync();
            return Cab_recetaMedica;
        }

        public async Task<bool> DeleteReceta(int id)
        {
            var receta = await _context.DetRecetaMedica.FindAsync(id);
            if (receta == null)
                return false;

            _context.DetRecetaMedica.Remove(receta);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }

    }
}
