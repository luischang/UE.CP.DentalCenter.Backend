using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class DetHistoriaMedica
    {
        public int? IdHistoriaMedica { get; set; }
        public int? IdCita { get; set; }
        public int? IdMedico { get; set; }
        public int? IdAsistente { get; set; }
        public int? IdRecetaMedica { get; set; }
        public int? IdTratamiento { get; set; }

        public virtual PersonalAdm? IdAsistenteNavigation { get; set; }
        public virtual Cita? IdCitaNavigation { get; set; }
        public virtual CabHistoriaMedica? IdHistoriaMedicaNavigation { get; set; }
        public virtual CabMedico? IdMedicoNavigation { get; set; }
        public virtual CabRecetaMedica? IdRecetaMedicaNavigation { get; set; }
        public virtual Tratamiento? IdTratamientoNavigation { get; set; }
    }
}
