using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class Cita
    {
        public Cita()
        {
            DetHistoriaMedica = new HashSet<DetHistoriaMedica>();
        }

        public int IdCita { get; set; }
        public int? IdPaciente { get; set; }
        public int? IdMedico { get; set; }
        public string? Estado { get; set; }
        public DateTime? FechaHora { get; set; }

        public virtual CabMedico? IdMedicoNavigation { get; set; }
        public virtual Paciente? IdPacienteNavigation { get; set; }
        public virtual ICollection<DetHistoriaMedica> DetHistoriaMedica { get; set; }
    }
}
