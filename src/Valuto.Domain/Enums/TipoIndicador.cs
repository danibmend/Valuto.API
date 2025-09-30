using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.Enums
{
    public enum TipoIndicador
    {
        [Description("Tipo de Contato")]
        TipoContato = 1,
        [Description("Classificação de Contato")]
        ClassificacaoContato = 2,
        [Description("Tipo de Endereço")]
        TipoEndereco = 3,
        [Description("Situação da Solicitação")]
        SituacaoSolicitacao = 4,
        [Description("Sexo")]
        Sexo = 5,
        [Description("Tipo de Solicitação")]
        TipoSolicitacao = 6,
        [Description("Tipo de Parceiro")]
        TipoParceiro = 7,
    }
}
