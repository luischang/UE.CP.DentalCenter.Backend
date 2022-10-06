using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE.CP.DentalCenter.DOMAIN.Core.DTOs;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.data;

namespace UE.CP.DentalCenter.DOMAIN.Infrastructure.Repositories
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly DentalCenterContext _context;

        public UsuarioRepositorio(DentalCenterContext context)
        {
            _context = context;
        }

        public async Task<int> SignUp(Usuario usuario)
        {
            var findUser = await _context
                                .Usuario
                                .Where(x => x.NumeroDocumento == usuario.NumeroDocumento &&
                                        x.TipoUsuario == usuario.TipoUsuario.ToUpper()).AnyAsync();
            if (findUser)
                return -1;
            _context.Usuario.Add(usuario);
            var rows = await _context.SaveChangesAsync();
            return rows > 0 ? usuario.Id : -1;
        }

        public async Task<Usuario> SignIn(int numeroDocumento
                                        , string contrasena
                                        , string tipoUsuario)
        {
            var result = await _context
                            .Usuario
                            .Where(x => x.NumeroDocumento == numeroDocumento &&
                            x.Contrasena == contrasena &&
                            x.TipoUsuario == tipoUsuario &&
                            x.Estado == "A").FirstOrDefaultAsync();
            return result;
        }
    }
}
