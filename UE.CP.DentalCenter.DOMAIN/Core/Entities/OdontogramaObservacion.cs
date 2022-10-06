using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class OdontogramaObservacion
    {
        public int Id { get; set; }
        public int? OdontogramaId { get; set; }
        public string? Observacion { get; set; }
        public bool? Estado { get; set; }

        public virtual Odontograma? Odontograma { get; set; }
    }
}
