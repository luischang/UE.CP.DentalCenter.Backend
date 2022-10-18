using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class CabHistoriaMedica
    {
        public int IdHistoriaMedica { get; set; }
        public int? IdPaciente { get; set; }
        public DateTime? FechaDeActualizacion { get; set; }

        public virtual Paciente? IdPacienteNavigation { get; set; }
    }
}
