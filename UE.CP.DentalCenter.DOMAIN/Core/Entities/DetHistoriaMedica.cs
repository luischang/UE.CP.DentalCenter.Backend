using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class DetHistoriaMedica
    {
        public DetHistoriaMedica()
        {
            CabHistoriaMedica = new HashSet<CabHistoriaMedica>();
        }

        public int IdDetHistoriaMedica { get; set; }
        public int IdCita { get; set; }
        public int IdMedico { get; set; }
        public int IdAsistente { get; set; }
        public int IdRecetaMedica { get; set; }
        public int IdTratamiento { get; set; }

        public virtual PersonalAdm IdAsistenteNavigation { get; set; } = null!;
        public virtual Cita IdCitaNavigation { get; set; } = null!;
        public virtual CabMedico IdMedicoNavigation { get; set; } = null!;
        public virtual CabRecetaMedica IdRecetaMedicaNavigation { get; set; } = null!;
        public virtual Tratamiento IdTratamientoNavigation { get; set; } = null!;
        public virtual ICollection<CabHistoriaMedica> CabHistoriaMedica { get; set; }
    }
}
