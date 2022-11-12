using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.DTOs
{
    public class LoginDTO
    {
        public int Id { get; set; }
        public string Usuario { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public int IdMedico { get; set; }
    }
    public class LoginData
    {
        public string Usuario { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
    }
    public class LoginGetShowDTO
    {
        public int Id { get; set; }
        public int IdMedico { get; set; }
    }
}
