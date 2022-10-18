using UE.CP.DentalCenter.DOMAIN.Core.Entities;

namespace UE.CP.DentalCenter.DOMAIN.Core.Interfaces
{
    public interface IPacienteRepository
    {
        Task<Paciente> GetPacienteByFrec(bool frec);
        Task<IEnumerable<Paciente>> GetPacientes();
        Task<bool> Insert(Paciente paciente);
    }
}