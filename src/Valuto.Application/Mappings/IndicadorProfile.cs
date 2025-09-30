using AutoMapper;
using Valuto.Domain.DTOs.Indicador;
using Valuto.Domain.DTOs.Rules;
using Valuto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Application.Mappings
{
    internal class IndicadorProfile : Profile
    {
        public IndicadorProfile()
        {
            #region DTOToEntity
            CreateProjection<IndicadorDTO, Indicador>();
            CreateProjection<IndicadorRulesDTO, Indicador>();
            #endregion

            #region EntityToDTO
            CreateProjection<Indicador, IndicadorResponseDTO>();
            #endregion
        }
    }
}
