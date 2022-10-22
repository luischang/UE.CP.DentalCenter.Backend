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
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Paciente, PacienteDTO>();
            CreateMap<PacienteDTO, Paciente>();
            CreateMap<Paciente, PacienteFrecuenteDTO>();
            CreateMap<PacienteFrecuenteDTO, Paciente>();
            CreateMap<CabMedico, CabMedicoParaFiltroPacnteDTO>();
            CreateMap<CabMedicoParaFiltroPacnteDTO, CabMedico>();
            CreateMap<HorarioDisponible,HorarioDisponibleDTO>();
            CreateMap<HorarioDisponibleDTO, HorarioDisponible>();
            CreateMap<TratamientoDTO, Tratamiento>();
            CreateMap<Tratamiento, TratamientoDTO>();
            CreateMap<RecetaDTO, CabeceraRecetaDTO>();
            CreateMap<CabeceraRecetaDTO, RecetaDTO>();
            CreateMap<RecetaPostDTO, DetRecetaMedica>();
            CreateMap<DetRecetaMedica, RecetaPostDTO>();
            CreateMap<CabRecetaMedica, CabeceraRecetaPostDTO>();
            CreateMap<CabeceraRecetaPostDTO, CabRecetaMedica>();
            CreateMap<CabeceraHistoriaCliDTO, CabHistoriaMedica>();
            CreateMap<CabHistoriaMedica, CabeceraHistoriaCliDTO>();
            CreateMap<CabeceraHistoriaCliPostDTO, CabHistoriaMedica>();
            CreateMap<CabHistoriaMedica, CabeceraHistoriaCliPostDTO>();
            CreateMap<CitaDTO, Cita>();
            CreateMap<Cita, CitaDTO>();
            CreateMap<HistoriaMedicaDTO, DetHistoriaMedica>();
            CreateMap<DetHistoriaMedica, HistoriaMedicaDTO>();
            CreateMap<DetHistoriaMedica, DetHistoTratamientoDTO>();
            CreateMap<DetHistoTratamientoDTO, DetHistoriaMedica>();
            CreateMap<CabFactura, CabFacturaDTO>();
            CreateMap<CabFacturaDTO, CabFactura>();
            CreateMap<DetFactura, FacturaDTO>();
            CreateMap<FacturaDTO, DetFactura>();
        }
    }
}
