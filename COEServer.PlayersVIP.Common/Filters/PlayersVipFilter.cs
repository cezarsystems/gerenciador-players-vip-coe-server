using System;

namespace COEServer.PlayersVIP.Common.Filters
{
    public class PlayersVipFilter
    {
        public int PlayerID { get; set; }
        public string PlayerNome { get; set; }
        public string PlayerNick { get; set; }
        public DateTime PlayerDataInclusaoSLOTVipInicial { get; set; }
        public DateTime PlayerDataInclusaoSLOTVipFinal { get; set; }
        public bool PlayerAtivo { get; set; }
        public bool PlayerEhAdmin { get; set; }
        public short? PlayerDiasVIP { get; set; }
    }
}
