using AutoMapper;
using Valuto.Domain.DTOs.Juridico;
using Valuto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Application.Mappings
{
    internal class JuridicoProfile : Profile
    {
        public JuridicoProfile()
        {
            #region DTOToEntity
            CreateProjection<JuridicoAtualizarDTO, Juridico>();
            CreateProjection<JuridicoCadastroDTO, Juridico>();

            CreateProjection<JuridicoContatoAtualizarDTO, Juridico>();
            #endregion

            #region EntityToDTO
            CreateProjection<Juridico, JuridicoResponseDTO>();
            CreateProjection<Juridico, JuridicoItemResponseDTO>();
            CreateProjection<Juridico, JuridicoListaResponseDTO>();

            CreateProjection<Juridico, JuridicoContatoResponseDTO>();
            #endregion
        }
    }
}
