using JesusEmNos.Domain.Entities;
using JesusEmNos.Domain.Interfaces.Repositories;
using JesusEmNos.Infrastructure.Repositories.Base;

namespace JesusEmNos.Infrastructure.Repositories
{
    public class EstadoRepository : BaseRepository<Estado>, IEstadoRepository
    {
        public EstadoRepository(IServiceProvider serviceProvider) : base(serviceProvider) { }
    }
}
