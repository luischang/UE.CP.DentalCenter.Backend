using UE.CP.DentalCenter.DOMAIN.Core.Entities;

namespace UE.CP.DentalCenter.DOMAIN.Core.Interfaces
{
    public interface ITratamientoRepository
    {
        Task<bool> Insert(Tratamiento tratamiento);
    }
}