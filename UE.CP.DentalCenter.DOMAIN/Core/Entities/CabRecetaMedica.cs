using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class CabRecetaMedica
    {
        public CabRecetaMedica()
        {
            DetFactura = new HashSet<DetFactura>();
            DetHistoriaMedica = new HashSet<DetHistoriaMedica>();
        }

        public int IdRecetaMedica { get; set; }
        public int? IdDetRecetaMedica { get; set; }
        public string? NombreDeClinica { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual DetRecetaMedica? IdDetRecetaMedicaNavigation { get; set; }
        public virtual ICollection<DetFactura> DetFactura { get; set; }
        public virtual ICollection<DetHistoriaMedica> DetHistoriaMedica { get; set; }
    }
}
