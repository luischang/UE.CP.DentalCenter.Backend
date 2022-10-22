using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.DTO_s
{
    public class CitaDTO
    {
        public int IdCita { get; set; }
        public int? IdPaciente { get; set; }
        public int? IdMedico { get; set; }
        public string? Estado { get; set; }
        public DateTime? FechaHora { get; set; }
    }
}
