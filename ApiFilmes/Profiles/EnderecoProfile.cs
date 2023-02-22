using ApiFilmes.Data.Dto;
using ApiFilmes.Models;
using AutoMapper;

namespace ApiFilmes.Profiles;

public class EnderecoProfile: Profile
{
    public EnderecoProfile()
    {
        CreateMap<CreateEnderecoDto, Endereco>();
        CreateMap<ReadEnderecoDto, Endereco>();
        CreateMap<UpdateEnderecoDto, Endereco>();
    }
}