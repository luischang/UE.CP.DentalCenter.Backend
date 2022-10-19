using UE.CP.DentalCenter.DOMAIN.Core.Entities;

namespace UE.CP.DentalCenter.DOMAIN.Core.Interfaces
{
    public interface ICabMedicoRepository
    {
        Task<IEnumerable<CabMedico>> GetMedicos();
    }
}