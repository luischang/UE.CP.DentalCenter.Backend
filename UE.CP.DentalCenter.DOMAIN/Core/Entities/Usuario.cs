using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            Cita = new HashSet<Cita>();
            HistoriaClinicaUsuarioMedico = new HashSet<HistoriaClinica>();
            HistoriaClinicaUsuarioPaciente = new HashSet<HistoriaClinica>();
            Odontograma = new HashSet<Odontograma>();
        }

        public int Id { get; set; }
        public string? Paterno { get; set; }
        public string? Materno { get; set; }
        public string? Nombres { get; set; }
        public int? NumeroDocumento { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public string? Teléfono { get; set; }
        public string? TipoUsuario { get; set; }
        public string? Contrasena { get; set; }
        public string? Estado { get; set; }

        public virtual ICollection<Cita> Cita { get; set; }
        public virtual ICollection<HistoriaClinica> HistoriaClinicaUsuarioMedico { get; set; }
        public virtual ICollection<HistoriaClinica> HistoriaClinicaUsuarioPaciente { get; set; }
        public virtual ICollection<Odontograma> Odontograma { get; set; }
    }
}
