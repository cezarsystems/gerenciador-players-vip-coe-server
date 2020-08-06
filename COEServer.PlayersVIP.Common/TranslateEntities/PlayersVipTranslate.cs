using System.Collections.Generic;
using System.Data;

namespace COEServer.PlayersVIP.Common.TranslateEntities
{
    public class PlayersVipTranslate
    {
        public static PlayersVip MapFromReader(IDataReader reader)
        {
            PlayersVip playersVip = new PlayersVip();
            while (reader.Read())
            {
                playersVip = new PlayersVip
                {
                    PlayerID = reader.GetInt32(0),
                    PlayerNome = reader.GetString(1) ?? "N/D",
                    PlayerNick = reader.GetString(2),
                    PlayerDataInclusaoSLOTVip = reader.GetDateTime(3),                    
                    PlayerAtivo = reader.GetBoolean(4),
                    PlayerEhAdmin = reader.GetBoolean(5),
                    PlayerDiasVIP = reader.GetInt16(6)
                };
            }

            return playersVip;
        }

        public static List<PlayersVip> MapFromReaderList(IDataReader reader)
        {
            List<PlayersVip> playersVipsList = new List<PlayersVip>();            
            while(reader.Read())
            {
                playersVipsList.Add(new PlayersVip
                {
                    PlayerID = reader.GetInt32(0),
                    PlayerNome = reader.GetString(1) ?? "N/D",
                    PlayerNick = reader.GetString(2),
                    PlayerDataInclusaoSLOTVip = reader.GetDateTime(3),
                    PlayerAtivo = reader.GetBoolean(4),
                    PlayerEhAdmin = reader.GetBoolean(5),
                    PlayerDiasVIP = reader.GetInt16(6)
                });
            }

            return playersVipsList;
        }
    }
}
