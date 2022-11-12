using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class Login
    {
        public int Id { get; set; }
        public string Usuario { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public int IdMedico { get; set; }

        public virtual CabMedico IdMedicoNavigation { get; set; } = null!;
    }
}
