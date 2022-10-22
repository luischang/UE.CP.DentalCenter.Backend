using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class DetFactura
    {
        public DetFactura()
        {
            CabFactura = new HashSet<CabFactura>();
        }

        public int IdDetFactura { get; set; }
        public int? IdTratamiento { get; set; }
        public int? IdRecetaMedica { get; set; }
        public double? Precio { get; set; }

        public virtual CabRecetaMedica? IdRecetaMedicaNavigation { get; set; }
        public virtual Tratamiento? IdTratamientoNavigation { get; set; }
        public virtual ICollection<CabFactura> CabFactura { get; set; }
    }
}
