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
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(IServiceProvider serviceProvider) : base(serviceProvider) { }
    }
}
