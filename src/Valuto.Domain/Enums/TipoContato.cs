using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.Enums
{
    public enum TipoContato
    {
        [Description("Telefone")]
        Telefone = 1,
        [Description("Email")]
        Email = 2,
    }
}
