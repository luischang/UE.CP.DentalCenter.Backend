using UE.CP.DentalCenter.DOMAIN.Core.Entities;

namespace UE.CP.DentalCenter.DOMAIN.Core.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<int> SignUp(Usuario usuario);
        Task<Usuario> SignIn(int numeroDocumento, string contrasena, string tipoUsuario);
    }
}