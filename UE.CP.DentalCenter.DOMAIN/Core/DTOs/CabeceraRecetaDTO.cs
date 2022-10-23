using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.DTO_s
{
    public class CabeceraRecetaDTO
    {
        public int IdRecetaMedica { get; set; }
        public string? NombreDeClinica { get; set; }
        public DateTime? Fecha { get; set; }


    }
    public class CabeceraRecetaPostDTO
    {
        public string? NombreDeClinica { get; set; }
        public DateTime? Fecha { get; set; }
    }

}
