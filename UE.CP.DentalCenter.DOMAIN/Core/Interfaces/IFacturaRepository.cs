using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;

namespace UE.CP.DentalCenter.DOMAIN.Core.Interfaces
{
    public interface IFacturaRepository
    {
        Task<bool> Insert(DetFactura detFactura);
        Task<bool> InsertCabF(CabFactura cabF);
    }
}
