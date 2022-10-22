using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class DetMedico
    {
        public DetMedico()
        {
            CabMedico = new HashSet<CabMedico>();
        }

        public int IdDetMedico { get; set; }
        public string Especialidad { get; set; } = null!;

        public virtual ICollection<CabMedico> CabMedico { get; set; }
    }
}
