using AutoMapper;
using JesusEmNos.Domain.DTOs.Parceiro;
using JesusEmNos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Application.Mappings
{
    internal class ParceiroProfile : Profile
    {
        public ParceiroProfile()
        {
            #region DTOToEntity
            CreateProjection<ParceiroAtualizarDTO, Parceiro>();
            CreateProjection<ParceiroCadastroDTO, Parceiro>();

            CreateProjection<ParceiroContatoAtualizarDTO, Parceiro>();
            #endregion

            #region EntityToDTO
            CreateProjection<Parceiro, ParceiroResponseDTO>();
            CreateProjection<Parceiro, ParceiroItemResponseDTO>();
            CreateProjection<Parceiro, ParceiroListaResponseDTO>();

            CreateProjection<Parceiro, ParceiroContatoResponseDTO>();
            #endregion
        }
    }
}
