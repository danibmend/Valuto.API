using System.ComponentModel;

namespace JesusEmNos.Domain.Enums
{
    public enum TipoParceiro
    {
        [Description("Igreja")]
        Igreja = 7,
        [Description("Instituição")]
        Instituicao = 8,
        [Description("Empresa")]
        Empresa = 9,
        [Description("Doador")]
        Doador = 10,
        [Description("Beneficiário")]
        Beneficiario = 11,
    }
}
