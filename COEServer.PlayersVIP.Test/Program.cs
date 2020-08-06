using COEServer.PlayersVIP.DataAccess;
using System;

namespace COEServer.PlayersVIP.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dados = new OperationsDataBase().GetPlayersVipById(3);
            //var dadosLista = new OperationsDataBase().GetPlayersVipAll();
            //var dadosExcluirPlayer = new OperationsDataBase().DeletarPlayerVIP(2);
            var dadosFilter = new OperationsDataBase().GetPlayersVipByFilter(
                new Common.Filters.PlayersVipFilter
                {
                    PlayerDataInclusaoSLOTVipInicial = DateTime.Now.AddYears(-10),
                    PlayerDataInclusaoSLOTVipFinal = DateTime.Now.AddYears(1)
                }
            );
            //var dadosInsert = new OperationsDataBase().InserirPlayerVIP(new Common.PlayersVip
            //{
            //    PlayerNome = "Joaquim",
            //    PlayerNick = "master_game_BR",
            //    PlayerAtivo = true,
            //    PlayerEhAdmin = false,
            //    PlayerDataInclusaoSLOTVip = DateTime.Now.AddDays(5),
            //    PlayerDiasVIP = 30
            //});
            //var dadosuPDATE = new OperationsDataBase().EditarPlayerVIP(new Common.PlayersVip
            //{
            //    PlayerNome = "Joaquim Silva",
            //    PlayerNick = "master_game_BR_ups",
            //    PlayerAtivo = true,
            //    PlayerEhAdmin = true,
            //    PlayerDataInclusaoSLOTVip = DateTime.Now.AddDays(90),
            //    PlayerDiasVIP = 365,
            //    PlayerID = 55
            //});
        }
    }
}
