﻿using Valuto.Domain.Interfaces;
using Valuto.Domain.Interfaces.Repositories;
using Valuto.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Infrastructure
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly ValutoContext _context;
        private readonly IServiceProvider _serviceProvider;

        public UnitOfWork(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<ValutoContext>();
            _serviceProvider = serviceProvider;
        }

        public ValutoContext Context => _context;
        public async Task BeginTransactionAsync() => await _context.Database.BeginTransactionAsync();
        public async Task CommitTransactionAsync() => await _context.Database.CommitTransactionAsync();
        public async Task RollBackTransactionAsync() => await _context.Database.RollbackTransactionAsync();

        public void Dispose()
        {
            GC.Collect();
        }

        public IEnderecoRepository Endereco => _serviceProvider.GetRequiredService<IEnderecoRepository>();

        public IEstadoRepository Estado => _serviceProvider.GetRequiredService<IEstadoRepository>();

        public IIndicadorRepository Indicador => _serviceProvider.GetRequiredService<IIndicadorRepository>();

        public IMunicipioRepository Municipio => _serviceProvider.GetRequiredService<IMunicipioRepository>();

        public IParceiroContatoRepository ParceiroContato => _serviceProvider.GetRequiredService<IParceiroContatoRepository>();

        public IParceiroRepository Parceiro => _serviceProvider.GetRequiredService<IParceiroRepository>();

        public ISolicitacaoParceiroRepository SolicitacaoParceiro => _serviceProvider.GetRequiredService<ISolicitacaoParceiroRepository>();

        public ISolicitacaoVoluntarioRepository SolicitacaoVoluntario => _serviceProvider.GetRequiredService<ISolicitacaoVoluntarioRepository>();

        public ITipoIndicadorRepository TipoIndicador => _serviceProvider.GetRequiredService<ITipoIndicadorRepository>();

        public IVoluntarioContatoRepository VoluntarioContato => _serviceProvider.GetRequiredService<IVoluntarioContatoRepository>();

        public IVoluntarioRepository Voluntario => _serviceProvider.GetRequiredService<IVoluntarioRepository>();
    }
}