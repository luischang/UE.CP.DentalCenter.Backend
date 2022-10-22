
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.DTO_s
{
    public class HistoriaMedicaDTO
    {
        public int IdDetHistoriaMedica { get; set; }
        public int? IdCita { get; set; }
        public int? IdMedico { get; set; }
        public int? IdAsistente { get; set; }
        public int? IdRecetaMedica { get; set; }
        public int? IdTratamiento { get; set; }
    }

    public class DetHistoTratamientoDTO
    {
        public int IdDetHistoriaMedica { get; set; }
        public int? IdCita { get; set; }
        public int? IdMedico { get; set; }
        public int? IdAsistente { get; set; }
        public int? IdRecetaMedica { get; set; }
        public int? IdTratamiento { get; set; }


    }

}
