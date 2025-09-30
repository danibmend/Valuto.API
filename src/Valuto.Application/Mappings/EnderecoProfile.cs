using AutoMapper;
using Valuto.Domain.DTOs.Endereco;
using Valuto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Application.Mappings
{
    internal class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            #region DTOToEntity
            CreateProjection<EnderecoAtualizarDTO, Endereco>();
            CreateProjection<EnderecoCadastroDTO, Endereco>();
            #endregion

            #region EntityToDTO
            CreateProjection<Endereco, EnderecoResponseDTO>();
            #endregion
        }
    }
}
