using AutoMapper;
using JesusEmNos.Domain.DTOs.Endereco;
using JesusEmNos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Application.Mappings
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
