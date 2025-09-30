using AutoMapper;
using Valuto.Domain.DTOs.Contato;
using Valuto.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Application.Mappings
{
    internal class ContatoProfile : Profile
    {
        public ContatoProfile()
        {
            #region DTOToEntity
            CreateProjection<ContatoDTO, Contato>();
            #endregion

            #region EntityToDTO
            CreateProjection<Contato, ContatoResponseDTO>();
            #endregion
        }
    }
}
