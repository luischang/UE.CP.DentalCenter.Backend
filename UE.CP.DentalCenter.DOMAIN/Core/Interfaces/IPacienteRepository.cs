using UE.CP.DentalCenter.DOMAIN.Core.DTOs;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;

namespace UE.CP.DentalCenter.DOMAIN.Core.Interfaces
{
    public interface IPacienteRepository
    {
        Task<IEnumerable<Paciente>> GetPacienteByFrec(bool frec);
        Task<IEnumerable<Paciente>> GetPacientes();
        Task<bool> Insert(Paciente paciente);
        Task<Paciente> getPacienteByNombre(string nombre);
        Task<Paciente> getPacienteByFecha(DateTime fecha);
    }
}