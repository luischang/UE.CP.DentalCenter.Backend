using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class Receta
    {
        public int Id { get; set; }
        public int? HistoriaClinicaId { get; set; }
        public string? Medicamento { get; set; }
        public int? Cantidad { get; set; }
        public string? Dosis { get; set; }
        public string? Intervalo { get; set; }

        public virtual HistoriaClinica? HistoriaClinica { get; set; }
    }
}
