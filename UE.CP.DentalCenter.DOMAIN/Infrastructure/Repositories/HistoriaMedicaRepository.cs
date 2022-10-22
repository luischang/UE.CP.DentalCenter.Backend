
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Data;

namespace UE.CP.DentalCenter.DOMAIN.Infraestructura.Repositories
{
    public class HistoriaMedicaRepository: IHistoriaMedicaRepository
    {
        private readonly DentalCenterContext _context;
        public HistoriaMedicaRepository(DentalCenterContext context)
        {
            _context = context;
        }

        public async Task<bool> InsertCabHistoriaM(CabHistoriaMedica cabH)//AñadirCabHistoriaMedica
        {
            await _context.CabHistoriaMedica.AddAsync(cabH);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }
        public async Task<bool> InsertDetHistoriaM(DetHistoriaMedica DetH)//AñadirDetHistoriamedica
        {
            await _context.DetHistoriaMedica.AddAsync(DetH);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }

        public async Task<bool> Update(DetHistoriaMedica detH)
        {
            _context.DetHistoriaMedica.Update(detH);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;

        }

        public async Task<IEnumerable<DetHistoriaMedica>> GetHisMedicaWithIdTramiento(int Id)
        {
            var DetHistoriaMedica = await _context.DetHistoriaMedica.Where(x => x.IdTratamiento == Id).ToListAsync();
            return DetHistoriaMedica;
        }
        public async Task<IEnumerable<DetHistoriaMedica>> GetHisMedicaNombreTramiento(string tr)
        {
            var tratamientoT = await _context.Tratamiento.Where(x => x.Descripcion == tr).ToListAsync();
            List<DetHistoriaMedica> detHistorias = new List<DetHistoriaMedica>();
            foreach (var tratamiento in tratamientoT)
            {
                detHistorias.AddRange(await _context.DetHistoriaMedica.Where(x => x.IdTratamiento == tratamiento.IdTratamiento).ToListAsync());
            }
            
          
            return detHistorias;
        }




    }
}
