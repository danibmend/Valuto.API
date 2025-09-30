using Valuto.Domain.DTOs.Contato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuto.Domain.DTOs.Pessoa
{
    public class PessoaContatoAtualizarDTO
    {
        public long Id { get; set; }
        public ContatoDTO? Contato { get; set; }
    }
}
