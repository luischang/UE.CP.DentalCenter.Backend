
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;

namespace UE.CP.DentalCenter.DOMAIN.Core.Interface
{
    public interface IRecetaRepository
    {
        Task<bool> InsertReceta(DetRecetaMedica receta);
        Task<bool> InsertCabReceta(CabRecetaMedica cabR);
        Task<IEnumerable<DetRecetaMedica>> GetRecetas();
        Task<IEnumerable<CabRecetaMedica>> GetCabRecetas();
        Task<bool> DeleteReceta(int id);
    }
}
