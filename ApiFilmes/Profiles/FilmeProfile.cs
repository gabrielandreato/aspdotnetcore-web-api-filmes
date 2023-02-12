using ApiFilmes.Dto;
using ApiFilmes.Models;
using AutoMapper;

namespace ApiFilmes.Profiles;

public class FilmeProfile: Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
    }
}