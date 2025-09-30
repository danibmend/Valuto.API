using AutoMapper;
using Valuto.Domain.DTOs.Voluntario;
using Valuto.Domain.Entities;

namespace Valuto.Application.Mappings
{
    internal class VoluntarioProfile : Profile
    {
        public VoluntarioProfile()
        {
            #region DTOToEntity
            CreateProjection<VoluntarioAtualizarDTO, Voluntario>();
            CreateProjection<VoluntarioCadastroDTO, Voluntario>();

            CreateProjection<VoluntarioContatoAtualizarDTO, Voluntario>();
            #endregion

            #region EntityToDTO
            CreateProjection<Voluntario, VoluntarioResponseDTO>();
            CreateProjection<Voluntario, VoluntarioItemResponseDTO>();
            CreateProjection<Voluntario, VoluntarioListaResponseDTO>();

            CreateProjection<Voluntario, VoluntarioContatoResponseDTO>();
            #endregion
        }
    }
}
