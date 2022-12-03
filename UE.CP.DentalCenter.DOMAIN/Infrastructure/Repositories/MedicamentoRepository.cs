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
    public class MedicamentoRepository:IMedicamentoRepository
    {
        private readonly Data.DentalCenterContext _context;
        public MedicamentoRepository(DentalCenterContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Medicamento>> GetMedicamentoss()
        {
            var med = await _context.Medicamento.ToListAsync();
            return med;
        }
        public async Task<IEnumerable<Medicamento>> GetMedicamentosByCab(int id)
        {
            var recetaMedicas = await _context.DetRecetaMedica.Where(x=>x.IdRecetaMedica==id).ToListAsync();
            //var ListaMedicamento = await _context.Medicamento.ToListAsync();
            List<Medicamento> medicamentos = new List<Medicamento>();
            foreach(var item in recetaMedicas)
            {
                medicamentos.Add(await _context.Medicamento.Where(x => x.IdMedicamento == item.IdMedicamento).FirstOrDefaultAsync());
            }
            //var med = await _context.Medicamento.ToListAsync();
            return medicamentos;
        }

    }
}
