using Microsoft.EntityFrameworkCore;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;

namespace UE.CP.DentalCenter.DOMAIN.Core.Interfaces
{
    public interface IPersonalAdmRepository
    {
        Task<IEnumerable<PersonalAdm>> GetPersonalAdm();

        Task<PersonalAdm> getPersonalAdmById(int id);
    }
}