using AutoMapper;
using RestAPI.Data.Entities;
using RestAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.API.Profiles
{
    public class DirectoresProfile : Profile
    {
        public DirectoresProfile()
        {
            CreateMap<Director, DirectorDto>()
                .ForMember(src => src.NombreCompleto, p => p.MapFrom(m => m.Nombre + " " + m.Apellido));

            CreateMap<DirectorParaCrearDto, Director>();
        }
    }
}
