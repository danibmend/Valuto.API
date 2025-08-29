using JesusEmNos.Domain.DTOs.Indicador;

namespace JesusEmNos.Domain.DTOs.Contato
{
    public class ContatoResponseDTO
    {
        public string? Valor { get; set; }
        public IndicadorResponseDTO? TipoContato { get; set; }
        public IndicadorResponseDTO? Classificacao { get; set; }
    }
}
