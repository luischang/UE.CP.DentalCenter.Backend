using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.DTOs
{
    public class MedicamentoDTO
    {
        public int IdMedicamento { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
        public double? Precio { get; set; }
    }
}
