using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class Archivo
    {
        public int Id { get; set; }
        public int? HistoriaClinicaId { get; set; }
        public string? Nombre { get; set; }
        public string? Formato { get; set; }

        public virtual HistoriaClinica? HistoriaClinica { get; set; }
    }
}
