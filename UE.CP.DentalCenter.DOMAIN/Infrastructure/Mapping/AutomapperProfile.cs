using AutoMapper;
using UE.CP.DentalCenter.DOMAIN.Core.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE.CP.DentalCenter.DOMAIN.Core.DTOs;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;

namespace UE.CP.DentalCenter.DOMAIN.Infrastructure.Mapping
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Paciente, PacienteDTO>();
            CreateMap<PacienteDTO, Paciente>();
            CreateMap<Paciente, PacientePostDTO>();
            CreateMap<PacientePostDTO, Paciente>();
            CreateMap<Paciente, PacienteFrecuenteDTO>();
            CreateMap<PacienteFrecuenteDTO, Paciente>(); //PACIENTE


            CreateMap<CabMedico, CabMedicoDTO>();
            CreateMap<CabMedicoDTO, CabMedico>();           
            CreateMap<CabMedico, CabMedicoParaFiltroPacnteDTO>();
            CreateMap<CabMedicoParaFiltroPacnteDTO, CabMedico>();
            CreateMap<DetMedico, DetMedicoDTO>();
            CreateMap<DetMedicoDTO, DetMedico>();
            CreateMap<CabMedico, MedicosConHorarioDTO>();
            CreateMap<MedicosConHorarioDTO, CabMedico>();//MEDICO


            CreateMap<HorarioDisponible, HorarioDisponibleDTO>();
            CreateMap<HorarioDisponibleDTO, HorarioDisponible>();
            CreateMap<HorarioDisponible, HorarioDisponiblePostDTO>();
            CreateMap<HorarioDisponiblePostDTO, HorarioDisponible>();//HORARIO DISPONIBLE

            CreateMap<TratamientoDTO, Tratamiento>();
            CreateMap<Tratamiento, TratamientoDTO>();
            CreateMap<TratamientoPostDTO, Tratamiento>();
            CreateMap<Tratamiento, TratamientoPostDTO>();//TRATAMIENTO

            CreateMap<CabRecetaMedica, CabeceraRecetaDTO>();
            CreateMap<CabeceraRecetaDTO, CabRecetaMedica>();
            CreateMap<RecetaDTO, DetRecetaMedica>();
            CreateMap<DetRecetaMedica, RecetaDTO>();
            CreateMap<RecetaPostDTO, DetRecetaMedica>();
            CreateMap<DetRecetaMedica, RecetaPostDTO>();
            CreateMap<CabRecetaMedica, CabeceraRecetaPostDTO>();
            CreateMap<CabeceraRecetaPostDTO, CabRecetaMedica>();//RECETA

            CreateMap<CabeceraHistoriaCliPostDTO, CabHistoriaMedica>();
            CreateMap<CabHistoriaMedica, CabeceraHistoriaCliPostDTO>();
            CreateMap<CabeceraHistoriaCliPostDTO, CabHistoriaMedica>();
            CreateMap<CabHistoriaMedica, CabeceraHistoriaCliPostDTO>();
            CreateMap<HistoriaMedicaDTO, DetHistoriaMedica>();
            CreateMap<DetHistoriaMedica, HistoriaMedicaDTO>();
            CreateMap<HistoriaMedicaPostDTO, CabHistoriaMedica>();
            CreateMap<CabHistoriaMedica, HistoriaMedicaPostDTO>();
            CreateMap<DetHistoTratamientoGetDTO, DetHistoriaMedica>();
            CreateMap<DetHistoriaMedica, DetHistoTratamientoGetDTO>();
            CreateMap<DetHistoriaMedica, DetHistoTratamientoPostDTO>();
            CreateMap<DetHistoTratamientoPostDTO, DetHistoriaMedica>();//HISTORIA MEDICA
            CreateMap<DetHistoriaMedica, DetHistoriaPostDTO>();
            CreateMap<DetHistoriaPostDTO, DetHistoriaMedica>();



            CreateMap<CitaDTO, Cita>();
            CreateMap<Cita, CitaDTO>();//CITA
            CreateMap<CitaPostDTO, Cita>();
            CreateMap<Cita, CitaPostDTO>();

            CreateMap<CabFactura, CabFacturaDTO>();
            CreateMap<CabFacturaDTO, CabFactura>();
            CreateMap<DetFactura, FacturaDTO>();
            CreateMap<FacturaDTO, DetFactura>();//FACTURA
            CreateMap<FacturaPostDTO, DetFactura>();
            CreateMap<DetFactura, FacturaPostDTO>();
            CreateMap<CabFacturaPostDTO, CabFactura>();
            CreateMap<CabFactura, CabFacturaPostDTO>();

            CreateMap<Especialidad, EspecialidadDTO>();
            CreateMap<EspecialidadDTO, Especialidad>();//ESPECIALIDAD

            CreateMap<Login, LoginDTO>();
            CreateMap<LoginDTO,Login>();
            CreateMap<Login, LoginGetShowDTO>();
            CreateMap<LoginGetShowDTO, Login>(); //LOGIN
            CreateMap<Login, LoginGetPShowDTO>();
            CreateMap<LoginGetPShowDTO, Login>();

        }
    }
}
