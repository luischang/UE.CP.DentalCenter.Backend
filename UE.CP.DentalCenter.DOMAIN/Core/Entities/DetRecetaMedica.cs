using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class DetRecetaMedica
    {
        public int? IdRecetaMedica { get; set; }
        public int? IdMedicamento { get; set; }
        public double? Dosis { get; set; }
        public string? UnidadMedida { get; set; }
        public string? Descripcion { get; set; }

        public virtual Medicamento? IdMedicamentoNavigation { get; set; }
        public virtual CabRecetaMedica? IdRecetaMedicaNavigation { get; set; }
    }
}
