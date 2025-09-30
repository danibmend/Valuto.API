using Valuto.Domain.Entities;
using Valuto.Domain.Interfaces.Repositories;
using Valuto.Infrastructure.Repositories.Base;

namespace Valuto.Infrastructure.Repositories
{
    public class EstadoRepository : BaseRepository<Estado>, IEstadoRepository
    {
        public EstadoRepository(IServiceProvider serviceProvider) : base(serviceProvider) { }
    }
}
