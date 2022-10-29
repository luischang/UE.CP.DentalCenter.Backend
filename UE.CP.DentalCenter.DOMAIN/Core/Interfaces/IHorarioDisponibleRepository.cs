using UE.CP.DentalCenter.DOMAIN.Core.Entities;

namespace UE.CP.DentalCenter.DOMAIN.Core.Interfaces
{
    public interface IHorarioDisponibleRepository
    {
        Task<IEnumerable<HorarioDisponible>> GetHorarioDisponibleById(int id);
        Task<IEnumerable<HorarioDisponible>> GetHorarioDisponibleByDoctorId(int id);
        Task<IEnumerable<HorarioDisponible>> GetHorarioDisponibleByDoctorName(string name);
    }
}