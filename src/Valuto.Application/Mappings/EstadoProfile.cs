using AutoMapper;
using Valuto.Domain.DTOs.Estado;
using Valuto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Application.Mappings
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
