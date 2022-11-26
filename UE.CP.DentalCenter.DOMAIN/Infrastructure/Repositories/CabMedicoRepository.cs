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
        private readonly Data.DentalCenterContext _context;
        public CabMedicoRepository(Data.DentalCenterContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CabMedico>> GetMedicos()
        {
            var medicos = await _context.CabMedico.ToListAsync();
            return medicos;
        }
        //public async Task<IEnumerable<CabMedico>> GetMedicosWithEspecialidadWithHorario()
        //{
        //    var medicos = await _context.CabMedico.Include(x=>x.HorarioDisponible).ToListAsync();//Include(x=>x.Especialidad).
        //    return medicos;
        //}
        public async Task<IEnumerable<CabMedico>> GetMedicosByIdEspecialidad(int id)
        {
            var especialidades = await _context.DetMedico.Where(x=>x.IdEspecialidad == id).ToListAsync();
            List<CabMedico> medicosByEs = new List<CabMedico>();
            foreach (var espe in especialidades)
            {
                medicosByEs.AddRange(await _context.CabMedico.Where(x => x.IdMedico == espe.IdMedico).ToListAsync());
            }
            
            return medicosByEs;
        }

        public async Task<IEnumerable<CabMedico>> GetMedicosByNombreEspecialidad(string especialidad)
        {
            var nombreEspecialidad = await _context.Especialidad.Where(x => x.Descripcion.Equals(especialidad)).FirstOrDefaultAsync();
            var especialidades = await _context.DetMedico.Where(x => x.IdEspecialidad == nombreEspecialidad.IdEspecialidad).ToListAsync();
            List<CabMedico> medicosByEs = new List<CabMedico>();
            foreach (var espe in especialidades)
            {
                medicosByEs.AddRange(await _context.CabMedico.Where(x => x.IdMedico == espe.IdMedico).ToListAsync());
            }

            return medicosByEs;
        }

        public async Task<CabMedico> GetMedicosById(int id)
        {
            var medico = await _context.CabMedico.Where(x=>x.IdMedico==id).FirstOrDefaultAsync();
            return medico;
        }

    }
}
