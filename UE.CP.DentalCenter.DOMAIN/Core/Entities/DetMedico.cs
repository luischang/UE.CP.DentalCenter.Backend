using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class DetMedico
    {
        public int IdDetMedico { get; set; }
        public int IdMedico { get; set; }
        public int IdEspecialidad { get; set; }

        public virtual Especialidad IdEspecialidadNavigation { get; set; } = null!;
    }
}
