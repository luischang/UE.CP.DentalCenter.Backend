using UE.CP.DentalCenter.DOMAIN.Core.Entities;

namespace UE.CP.DentalCenter.DOMAIN.Core.Interfaces
{
    public interface ICabMedicoRepository
    {
        Task<IEnumerable<CabMedico>> GetMedicos();
        Task<IEnumerable<CabMedico>> GetMedicosByIdEspecialidad(int id);
        Task<IEnumerable<CabMedico>> GetMedicosByNombreEspecialidad(string especialidad);

        //Task<IEnumerable<CabMedico>> GetMedicosWithEspecialidadWithHorario();
    }
}