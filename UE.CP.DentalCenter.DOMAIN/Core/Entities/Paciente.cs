using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class Paciente
    {
        public Paciente()
        {
            CabHistoriaMedica = new HashSet<CabHistoriaMedica>();
            Cita = new HashSet<Cita>();
            Login = new HashSet<Login>();
        }

        public int IdPaciente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Dni { get; set; }
        public DateTime? FechaDeNac { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public bool? Frecuente { get; set; }

        public virtual ICollection<CabHistoriaMedica> CabHistoriaMedica { get; set; }
        public virtual ICollection<Cita> Cita { get; set; }
        public virtual ICollection<Login> Login { get; set; }
    }
}
