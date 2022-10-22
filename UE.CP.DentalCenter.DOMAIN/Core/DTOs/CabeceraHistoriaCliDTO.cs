
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.DTO_s
{
    public class CabeceraHistoriaCliDTO
    {
        public int IdHistoriaMedica { get; set; }
        public int? IdDetHistoriaMedica { get; set; }
        public int? IdPaciente { get; set; }
        public DateTime? FechaDeActualizacion { get; set; }


    }
    public class CabeceraHistoriaCliPostDTO
    {
        public int IdHistoriaMedica { get; set; }
        public int? IdDetHistoriaMedica { get; set; }
        public int? IdPaciente { get; set; }
        public DateTime? FechaDeActualizacion { get; set; }


    }

}
