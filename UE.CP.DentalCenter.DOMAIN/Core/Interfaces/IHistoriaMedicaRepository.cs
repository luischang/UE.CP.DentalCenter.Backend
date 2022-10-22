using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.Interface
{
    public interface IHistoriaMedicaRepository
    {
        Task<bool> InsertCabHistoriaM(CabHistoriaMedica cabH);
        Task<bool> InsertDetHistoriaM(DetHistoriaMedica DetH);
        Task<bool> Update(DetHistoriaMedica detH);
        Task<IEnumerable<DetHistoriaMedica>> GetHisMedicaWithIdTramiento(int Id);
        Task<IEnumerable<DetHistoriaMedica>> GetHisMedicaNombreTramiento(string tr);
    }
}
