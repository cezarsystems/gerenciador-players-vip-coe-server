using System;
using System.Collections.Generic;
using System.Data;

namespace COEServer.PlayersVIP.Common.TranslateEntities
{
    public class AdministracaoPlayersVipTranslate
    {
        public static AdministracaoPlayersVip MapFromReader(IDataReader reader)
        {
            AdministracaoPlayersVip administracaoPlayersVip = new AdministracaoPlayersVip();
            while (reader.Read())
            {
                administracaoPlayersVip = new AdministracaoPlayersVip
                {
                    AdminID = Convert.ToInt32(reader["ADMIN_ID"]),
                    LvlAdminID = Convert.ToInt32(reader["LEVEL_ADMIN_ID"]),
                    AdminNome = reader["ADMIN_NOME"].ToString(),
                    AdminLogin = reader["ADMIN_LOGIN"].ToString(),
                    LevelAdministracaoPlayersVip = new LevelAdministracaoPlayersVip
                    {
                        LevelAdministracaoPlayersVipID = Convert.ToInt32(reader["LEVEL_ADMIN_ID"]),
                        LevelAdministracaoPlayersVipDescricao = reader["LEVEL_ADMIN_DESCRICAO"].ToString()
                    }
                };
            }

            return administracaoPlayersVip;
        }

        public static List<AdministracaoPlayersVip> MapFromReaderList(IDataReader reader)
        {
            List<AdministracaoPlayersVip> administracaoPlayersVipList = new List<AdministracaoPlayersVip>();
            while (reader.Read())
            {
                administracaoPlayersVipList.Add(new AdministracaoPlayersVip
                {
                    AdminID = Convert.ToInt32(reader["ADMIN_ID"]),
                    LvlAdminID = Convert.ToInt32(reader["LEVEL_ADMIN_ID"]),
                    AdminNome = reader["ADMIN_NOME"].ToString(),
                    AdminLogin = reader["ADMIN_LOGIN"].ToString(),
                    AdminDataCadastro = Convert.ToDateTime(reader["ADMIN_DATA_CADASTRO"]),
                    LevelAdministracaoPlayersVip = new LevelAdministracaoPlayersVip
                    {
                        LevelAdministracaoPlayersVipID = Convert.ToInt32(reader["LEVEL_ADMIN_ID"]),
                        LevelAdministracaoPlayersVipDescricao = reader["LEVEL_ADMIN_DESCRICAO"].ToString()
                    }
                });
            }

            return administracaoPlayersVipList;
        }
    }
}
