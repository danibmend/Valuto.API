using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Domain.Enums
{
    public enum Igreja
    {
        [Description("Central Luxemburgo")]
        CentralLuxemburgo = 24,
        [Description("Central Boulevard")]
        CentralBoulevard = 25,
        [Description("Central Contagem")]
        CentralContagem = 26,
        [Description("Central Pampulha")]
        CentralPampulha = 27,
        [Description("Central Vila Estela")]
        CentralVilaEstela = 28,
        [Description("Central Barreiro")]
        CentralBarreiro = 29,

        [Description("Catedral Metodista Central")]
        CatedralMetodistaCentral = 30,
        [Description("Metodista Santa Tereza")]
        MetodistaSantaTereza = 31,
        [Description("Metodista Barreiro")]
        MetodistaBarreiro = 32,
        [Description("Metodista Betim")]
        MetodistaBetim = 33,
        [Description("Metodista Vale do Jetobá")]
        MetodistaValeDoJetoba = 34,

        [Description("Igreja Boas Novas")]
        BoasNovasChurch = 35,
    }
}
