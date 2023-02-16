using ApiFilmes.Data.Dto;
using ApiFilmes.Models;

namespace ApiFilmes.Profiles;
using AutoMapper;


public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<Cinema, ReadCinemaDto>();
    }
}