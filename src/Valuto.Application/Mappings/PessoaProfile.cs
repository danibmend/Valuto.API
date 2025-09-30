using AutoMapper;
using Valuto.Domain.DTOs.Pessoa;
using Valuto.Domain.Entities;

namespace Valuto.Application.Mappings
{
    internal class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            #region DTOToEntity
            CreateProjection<PessoaAtualizarDTO, Pessoa>();
            CreateProjection<PessoaCadastroDTO, Pessoa>();

            CreateProjection<PessoaContatoAtualizarDTO, Pessoa>();
            #endregion

            #region EntityToDTO
            CreateProjection<Pessoa, PessoaResponseDTO>();
            CreateProjection<Pessoa, PessoaItemResponseDTO>();
            CreateProjection<Pessoa, PessoaListaResponseDTO>();

            CreateProjection<Pessoa, PessoaContatoResponseDTO>();
            #endregion
        }
    }
}
