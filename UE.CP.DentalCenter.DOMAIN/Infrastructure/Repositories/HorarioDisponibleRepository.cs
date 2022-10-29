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
            var horarios = await _context.HorarioDisponible.Where(x => x.IdMedico == id).Where(y=>y.Estado==1).ToListAsync();
            if (horarios == null)
                throw new Exception("Horarios no encontrados");
            return horarios;
        }
        public async Task<IEnumerable<HorarioDisponible>> GetHorarioDisponibleByDoctorId(int id)
        {
            var horarios = await _context.HorarioDisponible.Where(x => x.IdMedico == id).Where(y => y.Estado == 1).ToListAsync();
            if (horarios == null)
                throw new Exception("Horarios no encontrados");
            return horarios;
        }
        public async Task<IEnumerable<HorarioDisponible>> GetHorarioDisponibleByDoctorName(string name)
        {
            var nombreMedicos = await _context.CabMedico.Where(x => x.Nombre == name).ToListAsync();
            List<HorarioDisponible> horarios = new List<HorarioDisponible>();
            foreach(var nombre in nombreMedicos)
            {
                horarios.AddRange(await _context.HorarioDisponible.Where(x => x.IdMedico.Equals(nombre.IdMedico)).Where(y => y.Estado == 1).ToListAsync());
            }
          
            return horarios;
        }

       

    }
}
