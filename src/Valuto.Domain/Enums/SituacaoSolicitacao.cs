using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.Enums
{
    public enum SituacaoSolicitacao
    {
        [Description("Pendente")]
        Pendente = 12,
        [Description("Em Análise")]
        EmAnalise = 13,
        [Description("Aprovada")]
        Aprovada = 14,
        [Description("Rejeitada")]
        Rejeitada = 15,
        [Description("Cancelada")]
        Cancelada = 16,
    }
}
