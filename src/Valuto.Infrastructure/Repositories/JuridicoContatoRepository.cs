using Valuto.Domain.Entities;
using Valuto.Domain.Interfaces.Repositories;
using Valuto.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Infrastructure.Repositories
{
    public class JuridicoContatoRepository : BaseRepository<JuridicoContato>, IJuridicoContatoRepository
    {
        public JuridicoContatoRepository(IServiceProvider serviceProvider) : base(serviceProvider) { }
    }
}
