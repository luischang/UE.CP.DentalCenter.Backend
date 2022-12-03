using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UE.CP.DentalCenter.DOMAIN.Core.DTOs;
using UE.CP.DentalCenter.DOMAIN.Core.Interfaces;

namespace UE.CP.DentalCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalAdmController : ControllerBase
    {
        private readonly IPersonalAdmRepository _personalAdmRepository;
        private readonly IMapper _mapper;
        public PersonalAdmController(IPersonalAdmRepository personalAdmRepository, IMapper mapper)
        {
            _personalAdmRepository = personalAdmRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var personalAdm = await _personalAdmRepository.GetPersonalAdm();

            var personalAdmList = _mapper.Map<List<PersonalAdmDTO>>(personalAdm);


            return Ok(personalAdmList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonalAdmsById(int id)
        {
            var personalAdms = await _personalAdmRepository.getPersonalAdmById(id);
            var personalAdmList = _mapper.Map<PersonalAdmDTO>(personalAdms);
            if (personalAdms == null)
                return NotFound();
            return Ok(personalAdmList);
        }
    }
}
