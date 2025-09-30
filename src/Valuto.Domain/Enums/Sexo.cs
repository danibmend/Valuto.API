using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.Enums
{
    public enum Sexo
    {
        [Description("Masculino")]
        Masculino = 17,
        [Description("Feminino")]
        Feminino = 18,
        [Description("Outro")]
        Outro = 19,
        [Description("Não Informado")]
        NaoInformado = 20
    }
}
