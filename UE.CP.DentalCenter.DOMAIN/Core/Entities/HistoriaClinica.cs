using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class HistoriaClinica
    {
        public HistoriaClinica()
        {
            Archivo = new HashSet<Archivo>();
            Receta = new HashSet<Receta>();
            Tratamiento = new HashSet<Tratamiento>();
        }

        public int Id { get; set; }
        public int? UsuarioPacienteId { get; set; }
        public int? UsuarioMedicoId { get; set; }
        public DateTime? FechaAtencion { get; set; }
        public string? Observacion { get; set; }

        public virtual Usuario? UsuarioMedico { get; set; }
        public virtual Usuario? UsuarioPaciente { get; set; }
        public virtual ICollection<Archivo> Archivo { get; set; }
        public virtual ICollection<Receta> Receta { get; set; }
        public virtual ICollection<Tratamiento> Tratamiento { get; set; }
    }
}
