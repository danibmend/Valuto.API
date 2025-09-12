using AutoMapper;
using JesusEmNos.Domain.DTOs.Estado;
using JesusEmNos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Application.Mappings
{
    internal class EstadoProfile : Profile
    {
        public EstadoProfile()
        {
            #region DTOToEntity

            #endregion

            #region EntityToDTO
            CreateProjection<Estado, EstadoResponseDTO>();
            #endregion
        }
    }
}
