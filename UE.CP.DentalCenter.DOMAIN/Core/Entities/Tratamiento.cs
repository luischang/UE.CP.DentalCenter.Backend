using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class Tratamiento
    {
        public Tratamiento()
        {
            DetFactura = new HashSet<DetFactura>();
            DetHistoriaMedica = new HashSet<DetHistoriaMedica>();
        }

        public int IdTratamiento { get; set; }
        public string? Tipo { get; set; }
        public int? DuracionDias { get; set; }
        public double? Precio { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<DetFactura> DetFactura { get; set; }
        public virtual ICollection<DetHistoriaMedica> DetHistoriaMedica { get; set; }
    }
}
