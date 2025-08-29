using JesusEmNos.Domain.Entities;
using JesusEmNos.Domain.Interfaces.Repositories;
using JesusEmNos.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Infrastructure.Repositories
{
    public class MunicipioRepository : BaseRepository<Municipio>, IMunicipioRepository
    {
        public MunicipioRepository(IServiceProvider serviceProvider) : base(serviceProvider) { }
    }
}
