using System;

namespace COEServer.PlayersVIP.Common
{
    public class AdministracaoPlayersVip
    {
        public int AdminID { get; set; }
        public int LvlAdminID { get; set; }
        public string AdminNome { get; set; }
        public string AdminLogin { get; set; }
        public string AdminPassword { get; set; }
        public DateTime AdminDataCadastro { get; set; }
        public LevelAdministracaoPlayersVip LevelAdministracaoPlayersVip { get; set; }
    }
}
