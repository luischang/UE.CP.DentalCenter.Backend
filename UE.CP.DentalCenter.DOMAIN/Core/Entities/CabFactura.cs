using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class CabFactura
    {
        public int IdFactura { get; set; }
        public int? IdDetFactura { get; set; }
        public int? IdPaciente { get; set; }
        public int? IdCita { get; set; }
        public DateTime? FechaHora { get; set; }
        public double? PrecioTotal { get; set; }

        public virtual DetFactura? IdDetFacturaNavigation { get; set; }
    }
}
