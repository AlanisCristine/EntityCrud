using AutoMapper;
using CrudEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.DTOs
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ReadProdutoDTO,Produto>().ReverseMap();
            CreateMap<ReadPessoaDTO,Pessoa>().ReverseMap();
            CreateMap<ReadCidadeDTO,Cidade>().ReverseMap();

        }
    }
}
