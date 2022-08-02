using AutoMapper;
using desafio_backend_stefanini.API.Models;
using desafio_backend_stefanini.Application.DTOs;

namespace desafio_backend_stefanini.API.DTOs.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<IncluirPessoaDTO, Pessoa>();
            CreateMap<AlterarPessoaDTO, Pessoa>();

            CreateMap<IncluirCidadeDTO, Cidade>();
            CreateMap<AlterarCidadeDTO, Cidade>();     
            
            CreateMap<PessoaDTO, Pessoa>();
            CreateMap<CidadeDTO, Cidade>();
        }
    }
}
