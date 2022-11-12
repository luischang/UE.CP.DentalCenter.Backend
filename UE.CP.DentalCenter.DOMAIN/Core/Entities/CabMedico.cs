using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class CabMedico
    {
        public CabMedico()
        {
            Cita = new HashSet<Cita>();
            DetHistoriaMedica = new HashSet<DetHistoriaMedica>();
            DetMedico = new HashSet<DetMedico>();
            Login = new HashSet<Login>();
        }

        public int IdMedico { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Genero { get; set; }

        public virtual ICollection<Cita> Cita { get; set; }
        public virtual ICollection<DetHistoriaMedica> DetHistoriaMedica { get; set; }
        public virtual ICollection<DetMedico> DetMedico { get; set; }
        public virtual ICollection<Login> Login { get; set; }
    }
}
