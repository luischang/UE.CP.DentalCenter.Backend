using System;
using System.Collections.Generic;

namespace UE.CP.DentalCenter.DOMAIN.Core.Entities
{
    public partial class Odontograma
    {
        public Odontograma()
        {
            OdontogramaObservacion = new HashSet<OdontogramaObservacion>();
        }

        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public int? NumeroDiente { get; set; }
        public string? Descripcion { get; set; }

        public virtual Usuario? Usuario { get; set; }
        public virtual ICollection<OdontogramaObservacion> OdontogramaObservacion { get; set; }
    }
}
