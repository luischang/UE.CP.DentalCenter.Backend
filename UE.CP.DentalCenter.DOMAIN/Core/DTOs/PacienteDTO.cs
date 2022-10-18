using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.DTOs
{
    public class PacienteDTO
    {
        public int IdPaciente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Dni { get; set; }
        public DateTime? FechaDeNac { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public bool? Frecuente { get; set; }
    }
    public class PacienteFrecuenteDTO
    {
        public int IdPaciente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public bool? Frecuente { get; set; }
    }
}
