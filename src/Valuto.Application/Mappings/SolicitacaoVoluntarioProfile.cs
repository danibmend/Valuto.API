using AutoMapper;
using Valuto.Domain.DTOs.SolicitacaoVoluntario;
using Valuto.Domain.Entities;

namespace Valuto.Application.Mappings
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
