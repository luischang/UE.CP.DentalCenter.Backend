using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class Tratamiento
    {
        public int Id { get; set; }
        public int? HistoriaClinicaId { get; set; }
        public string? Descripcion { get; set; }
        public string? Material { get; set; }
        public decimal? Presupuesto { get; set; }
        public string? Observaciones { get; set; }

        public virtual HistoriaClinica? HistoriaClinica { get; set; }
    }
}
