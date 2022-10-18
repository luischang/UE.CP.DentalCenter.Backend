using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class DetMedico
    {
        public int? IdMedico { get; set; }
        public string? Especialidad { get; set; }

        public virtual CabMedico? IdMedicoNavigation { get; set; }
    }
}
