using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.DTOs
{
    public class FacturaDTO
    {
        public int IdDetFactura { get; set; }
        public int? IdTratamiento { get; set; }
        public int? IdRecetaMedica { get; set; }
        public double? Precio { get; set; }
    }
    public class FacturaPostDTO
    {
        public int IdFactura { get; set; }
        public int? IdTratamiento { get; set; }
        public int? IdRecetaMedica { get; set; }
        public double? Precio { get; set; }
    }

}
