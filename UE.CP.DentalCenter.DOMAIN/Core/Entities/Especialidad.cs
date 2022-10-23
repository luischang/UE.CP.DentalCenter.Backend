using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class Especialidad
    {
        public Especialidad()
        {
            DetMedico = new HashSet<DetMedico>();
        }

        public int IdEspecialidad { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<DetMedico> DetMedico { get; set; }
    }
}
