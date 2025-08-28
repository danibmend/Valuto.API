using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.Enums
{
    public enum TipoSolicitacao
    {
        [Description("Cadastro")]
        Cadastro = 21,
        [Description("Atualização")]
        Atualizacao = 22,
        [Description("Remoção")]
        Remocao = 23,
    }
}
