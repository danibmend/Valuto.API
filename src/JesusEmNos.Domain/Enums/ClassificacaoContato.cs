using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.Enums
{
    public enum ClassificacaoContato
    {
        [Description("Pessoal")]
        Pessoal = 3,
        [Description("Profissional")]
        Profissional = 4,
    }
}
