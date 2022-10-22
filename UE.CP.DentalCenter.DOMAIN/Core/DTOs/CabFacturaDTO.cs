using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.DTOs
{
    public class CabFacturaDTO
    {
        public int IdFactura { get; set; }
        public int? IdDetFactura { get; set; }
        public int? IdPaciente { get; set; }
        public int? IdCita { get; set; }
        public DateTime? FechaHora { get; set; }
        public double? PrecioTotal { get; set; }
    }
}
