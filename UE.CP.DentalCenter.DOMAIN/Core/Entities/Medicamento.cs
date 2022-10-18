using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class Medicamento
    {
        public int IdMedicamento { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
        public double? Precio { get; set; }
    }
}
