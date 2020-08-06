using System;

namespace COEServer.PlayersVIP.Common
{
    public class PlayersVip
    {
        public int PlayerID { get; set; }
        public string PlayerNome { get; set; }
        public string PlayerNick { get; set; }
        public DateTime PlayerDataInclusaoSLOTVip { get; set; }
        public bool PlayerAtivo { get; set; }
        public bool PlayerEhAdmin { get; set; }
        public short? PlayerDiasVIP { get; set; }
    }
}
