﻿using AutoMapper;
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
            CreateMap<Usuario, UsuarioRegisterDTO>();
            CreateMap<UsuarioRegisterDTO, Usuario>();
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<UsuarioDTO, Usuario>();
        }

    }
}
