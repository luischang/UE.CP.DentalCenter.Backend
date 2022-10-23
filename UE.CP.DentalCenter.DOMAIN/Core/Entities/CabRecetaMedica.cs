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
            DetRecetaMedica = new HashSet<DetRecetaMedica>();
        }

        public int IdRecetaMedica { get; set; }
        public string? NombreDeClinica { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual ICollection<DetFactura> DetFactura { get; set; }
        public virtual ICollection<DetHistoriaMedica> DetHistoriaMedica { get; set; }
        public virtual ICollection<DetRecetaMedica> DetRecetaMedica { get; set; }
    }
}
