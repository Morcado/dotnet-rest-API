using AutoMapper;
using RestAPI.Data.Entities;
using RestAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.API.Profiles
{
    public class PeliculaProfile : Profile
    {
        public PeliculaProfile()
        {
            CreateMap<PeliculaParaCrearDto, Pelicula>();
            CreateMap<Pelicula, PeliculaDto>();
            CreateMap<PeliculaParaModificarDto, Pelicula>();
        }
    }
}
