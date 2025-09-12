using AutoMapper;
using JesusEmNos.Domain.DTOs.Indicador;
using JesusEmNos.Domain.DTOs.Rules;
using JesusEmNos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Application.Mappings
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
