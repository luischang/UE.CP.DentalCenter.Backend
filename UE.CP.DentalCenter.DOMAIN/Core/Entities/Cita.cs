using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class Cita
    {
        public int Id { get; set; }
        public string? Paterno { get; set; }
        public string? Materno { get; set; }
        public string? Nombres { get; set; }
        public int? NumeroDocumento { get; set; }
        public string? Correo { get; set; }
        public string? Teléfono { get; set; }
        public DateTime? FechaYhora { get; set; }
        public int? UsuarioId { get; set; }

        public virtual Usuario? Usuario { get; set; }
    }
}
