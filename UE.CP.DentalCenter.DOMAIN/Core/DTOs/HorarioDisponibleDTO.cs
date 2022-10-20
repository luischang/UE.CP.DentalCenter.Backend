using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.DTOs
{
    public class HorarioDisponibleDTO
    {
        public int IdMedico { get; set; }
        public DateTime? Dia { get; set; }
        public TimeSpan? HoraIni { get; set; }
        public TimeSpan? HoraFin { get; set; }
        public int? Estado { get; set; }//0 es libre, 1 es ocupado
    }
}
