using AutoMapper;
using Valuto.Domain.DTOs.SolicitacaoParceiro;
using Valuto.Domain.DTOs.SolicitacaoVoluntario;
using Valuto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Application.Mappings
{
    internal class SolicitacaoParceiroProfile : Profile
    {
        public SolicitacaoParceiroProfile()
        {
            #region DTOToEntity
            CreateProjection<SolicitacaoParceiroAtualizarDTO, SolicitacaoParceiro>();
            CreateProjection<SolicitacaoParceiroCadastroDTO, SolicitacaoParceiro>();
            #endregion

            #region EntityToDTO
            CreateProjection<SolicitacaoParceiro, SolicitacaoParceiroResponseDTO>();
            CreateProjection<SolicitacaoParceiro, SolicitacaoParceiroItemResponseDTO>();
            CreateProjection<SolicitacaoParceiro, SolicitacaoVoluntarioListaResponseDTO>();
            #endregion
        }
    }
}
