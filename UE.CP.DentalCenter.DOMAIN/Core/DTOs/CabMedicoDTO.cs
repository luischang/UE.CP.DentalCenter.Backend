using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE.CP.DentalCenter.DOMAIN.Core.DTOs
{
    public class CabMedicoDTO
    {
        public int IdMedico { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Genero { get; set; }
    }
    public class CabMedicoParaFiltroPacnteDTO
    {
        public int IdMedico { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
    }
    public class DetMedicoDTO//include especialidad
    {
        public int IdMedico { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public IEnumerable<EspecialidadDTO>? Especialidad { get; set; }
        public IEnumerable<HorarioDisponibleDTO>? HorarioDisponible { get; set; }
    }
    public class MedicosConHorarioDTO
    {
        public int IdMedico { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public IEnumerable<EspecialidadDTO>? Especialidad { get; set; }
        public IEnumerable<HorarioDisponibleDTO>? HorarioDisponible { get; set; }

    }

}
