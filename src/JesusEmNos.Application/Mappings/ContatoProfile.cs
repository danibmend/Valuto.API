using AutoMapper;
using JesusEmNos.Domain.DTOs.Contato;
using JesusEmNos.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Application.Mappings
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
