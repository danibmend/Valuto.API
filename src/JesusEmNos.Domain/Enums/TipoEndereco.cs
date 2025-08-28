using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.Enums
{
    public enum TipoEndereco
    {
        [Description("Residencial")]
        Residencial = 5,
        [Description("Comercial")]
        Comercial = 6,
    }
}
