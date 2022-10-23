using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.DTO_s
{
    public class RecetaDTO
    {
        public int IdDetRecetaMedica { get; set; }
        public int? IdMedicamento { get; set; }
        public double? Dosis { get; set; }
        public string? UnidadMedida { get; set; }
        public string? Descripcion { get; set; }
    }

    public class RecetaPostDTO
    {
        public int? IdMedicamento { get; set; }
        public double? Dosis { get; set; }
        public string? UnidadMedida { get; set; }
        public string? Descripcion { get; set; }
    }

}
