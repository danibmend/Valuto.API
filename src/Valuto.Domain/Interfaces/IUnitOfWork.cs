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
        IParceiroContatoRepository ParceiroContato { get; }
        IParceiroRepository Parceiro { get; }
        ISolicitacaoParceiroRepository SolicitacaoParceiro { get; }
        ISolicitacaoVoluntarioRepository SolicitacaoVoluntario { get; }
        ITipoIndicadorRepository TipoIndicador { get; }
        IVoluntarioContatoRepository VoluntarioContato { get; }
        IVoluntarioRepository Voluntario { get; }


        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        void Dispose();
        Task RollBackTransactionAsync();
    }
}
