using AutoMapper;
using JesusEmNos.Domain.DTOs.SolicitacaoVoluntario;
using JesusEmNos.Domain.Entities;

namespace JesusEmNos.Application.Mappings
{
    internal class SolicitacaoVoluntarioProfile : Profile
    {
        public SolicitacaoVoluntarioProfile()
        {
            #region DTOToEntity
            CreateProjection<SolicitacaoVoluntarioAtualizarDTO, SolicitacaoVoluntario>();
            CreateProjection<SolicitacaoVoluntarioCadastroDTO, SolicitacaoVoluntario>();
            #endregion

            #region EntityToDTO
            CreateProjection<SolicitacaoVoluntario, SolicitacaoVoluntarioResponseDTO>();
            CreateProjection<SolicitacaoVoluntario, SolicitacaoVoluntarioItemResponseDTO>();
            CreateProjection<SolicitacaoVoluntario, SolicitacaoVoluntarioListaResponseDTO>();
            #endregion
        }
    }
}
