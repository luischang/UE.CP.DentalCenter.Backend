using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.Interface
{
    public interface ICitaRepository
    {
        Task<bool> Insert(Cita cita);
        Task<Cita> GetCitaById(int id);
        Task<Cita> GetPacienteById(int id);
        Task<bool> Update(Cita cita);
        Task<IEnumerable<Cita>> GetListPacienteById(int id);
    }
}
