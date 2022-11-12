using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;

namespace UE.CP.DentalCenter.DOMAIN.Infrastructure.Repositories
{
    public class LoginRepository:ILoginRepository
    {
        private readonly Data.DentalCenterContext _context;
        public LoginRepository(Data.DentalCenterContext context)
        {
            _context = context;
        }
        public async Task<Login> GetLogin(string user, string password)
        {
            var login = await _context.Login.Where(x=>x.Usuario==user && x.Contraseña == password).FirstOrDefaultAsync();
            return login;
        }
    }
}
