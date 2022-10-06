using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.DTOs
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string? Paterno { get; set; }
        public string? Materno { get; set; }
        public string? Nombres { get; set; }
        public int? NumeroDocumento { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public string? Teléfono { get; set; }
        public string? TipoUsuario { get; set; }
        public string? Contrasena { get; set; }
        public string? Estado { get; set; }
    }

    public class UsuarioRegisterDTO 
    {
        public string? Paterno { get; set; }
        public string? Materno { get; set; }
        public string? Nombres { get; set; }
        public int? NumeroDocumento { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public string? Teléfono { get; set; }
        public string? TipoUsuario { get; set; }
        public string? Contrasena { get; set; }
    }

    public class UsuarioSingInDTO
    {
        public int? NumeroDocumento { get; set; }
        public string? Contrasena { get; set; }
        public string? TipoUsuario { get; set; }
    }
}
