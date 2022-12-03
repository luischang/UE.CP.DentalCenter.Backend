using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;
using UE.CP.DentalCenter.DOMAIN.Infrastructure.Data;

namespace UE.CP.DentalCenter.DOMAIN.Infrastructure.Repositories
{
    public class PersonalAdmRepository : IPersonalAdmRepository
    {
        private readonly Data.DentalCenterContext _context;
        public PersonalAdmRepository(DentalCenterContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<PersonalAdm>> GetPersonalAdm()
        {
            var personalAdm = await _context.PersonalAdm.ToListAsync();
            return personalAdm;
        }
        public async Task<PersonalAdm> getPersonalAdmById(int id)
        {
            var personalAdm = await _context.PersonalAdm.Where(X => X.IdAsistente == id).FirstOrDefaultAsync();
            return personalAdm;
        }
    }
}
