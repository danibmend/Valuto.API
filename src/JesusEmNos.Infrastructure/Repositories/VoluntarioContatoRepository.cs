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
    public class VoluntarioContatoRepository : BaseRepository<VoluntarioContato>, IVoluntarioContatoRepository
    {
        public VoluntarioContatoRepository(IServiceProvider serviceProvider) : base(serviceProvider) { }
    }
}
