using AutoMapper;
using Valuto.Domain.DTOs.Municipio;
using Valuto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Application.Mappings
{
    internal class MunicipioProfile : Profile
    {
        public MunicipioProfile()
        {
            #region DTOToEntity
            CreateProjection<MunicipioDTO, Municipio>();
            #endregion

            #region EntityToDTO
            CreateProjection<Municipio, MunicipioResponseDTO>();
            #endregion
        }
    }
}
