using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class HorarioDisponible
    {
        public int IdHorarioDisponible { get; set; }
        public int IdMedico { get; set; }
        public DateTime? Dia { get; set; }
        public TimeSpan? HoraIni { get; set; }
        public TimeSpan? HoraFin { get; set; }
        public int? Estado { get; set; }

        public virtual CabMedico IdMedicoNavigation { get; set; } = null!;
        public IEnumerable<CabMedico> nameMedico { get; set; }
    }
}
