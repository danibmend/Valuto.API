using AutoMapper;
using JesusEmNos.Domain.DTOs.Voluntario;
using JesusEmNos.Domain.Entities;

namespace JesusEmNos.Application.Mappings
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
