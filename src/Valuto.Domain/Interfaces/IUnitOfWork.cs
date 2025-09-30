using Valuto.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IEnderecoRepository Endereco { get; }
        IEstadoRepository Estado { get; }
        IIndicadorRepository Indicador { get; }
        IMunicipioRepository Municipio { get; }
        IJuridicoContatoRepository JuridicoContato { get; }
        IJuridicoRepository Juridico { get; }
        ITipoIndicadorRepository TipoIndicador { get; }
        IPessoaContatoRepository PessoaContato { get; }
        IPessoaRepository Pessoa { get; }


        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        void Dispose();
        Task RollBackTransactionAsync();
    }
}
