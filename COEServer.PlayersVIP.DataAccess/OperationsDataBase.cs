using COEServer.PlayersVIP.Common;
using COEServer.PlayersVIP.Common.TranslateEntities;
using COEServer.PlayersVIP.Common.Filters;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace COEServer.PlayersVIP.DataAccess
{
    public class OperationsDataBase
    {
        private const string _conStringDB = @"Data Source=.\_dbPlayersVip\dbCOEServerSistemaPlayersVIP.db;Version=3";

        public PlayersVip GetPlayersVipById(int id)
        {
            try
            {
                using (var con = new SQLiteConnection(_conStringDB))
                {
                    using (var cmd = new SQLiteCommand(con))
                    {
                        cmd.CommandText = string.Format("SELECT * FROM TB_COESERVER_PLAYERS_VIP WHERE PLAYER_ID = {0}", id);
                        cmd.CommandType = System.Data.CommandType.Text;

                        if (con.State == System.Data.ConnectionState.Closed)
                            con.Open();

                        SQLiteDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                            return PlayersVipTranslate.MapFromReader(reader);
                        else
                            return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar o Player VIP na base de dados: " + ex.Message);
            }
        }

        public List<PlayersVip> GetPlayersVipAll()
        {
            try
            {
                using (var con = new SQLiteConnection(_conStringDB))
                {
                    using (var cmd = new SQLiteCommand(con))
                    {
                        cmd.CommandText = string.Format("SELECT * FROM TB_COESERVER_PLAYERS_VIP;");
                        cmd.CommandType = System.Data.CommandType.Text;

                        if (con.State == System.Data.ConnectionState.Closed)
                            con.Open();

                        SQLiteDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                            return PlayersVipTranslate.MapFromReaderList(reader);
                        else
                            return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar os Players VIP's na base de dados: " + ex.Message);
            }
        }

        public List<PlayersVip> GetPlayersVipByFilter(PlayersVipFilter playersVipFilter)
        {
            try
            {
                using (var con = new SQLiteConnection(_conStringDB))
                {
                    using (var cmd = new SQLiteCommand(con))
                    {
                        cmd.CommandText = string.Format("SELECT * FROM TB_COESERVER_PLAYERS_VIP WHERE 1 = 1 ");

                        // filtros
                        if (!string.IsNullOrEmpty(playersVipFilter.PlayerNome))
                            cmd.CommandText += string.Format("AND PLAYER_NOME LIKE '%{0}%' ", playersVipFilter.PlayerNome);

                        if (!string.IsNullOrEmpty(playersVipFilter.PlayerNick))
                            cmd.CommandText += string.Format("AND PLAYER_NICK LIKE '%{0}%' ", playersVipFilter.PlayerNick);

                        if (playersVipFilter.PlayerAtivo)
                            cmd.CommandText += string.Format("AND PLAYER_ATIVO = {0} ", playersVipFilter.PlayerAtivo);

                        if (playersVipFilter.PlayerEhAdmin)
                            cmd.CommandText += string.Format("AND PLAYER_EH_ADMIN = {0} ", playersVipFilter.PlayerEhAdmin);

                        if (playersVipFilter.PlayerDiasVIP != short.MinValue)
                            cmd.CommandText += string.Format("AND PLAYER_DIAS_VIP = {0} ", playersVipFilter.PlayerDiasVIP.Value);

                        if (playersVipFilter.PlayerDataInclusaoSLOTVipInicial != DateTime.MinValue || playersVipFilter.PlayerDataInclusaoSLOTVipFinal != DateTime.Now)
                            cmd.CommandText +=
                                string.Format("AND PLAYER_DT_INCLUSAO_SLOT_VIP BETWEEN '{0}' AND '{1}';",
                                playersVipFilter.PlayerDataInclusaoSLOTVipInicial.ToString("yyyy-MM-dd"),
                                playersVipFilter.PlayerDataInclusaoSLOTVipFinal.ToString("yyyy-MM-dd"));

                        cmd.CommandType = System.Data.CommandType.Text;

                        if (con.State == System.Data.ConnectionState.Closed)
                            con.Open();

                        SQLiteDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                            return PlayersVipTranslate.MapFromReaderList(reader);
                        else
                            return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar (por filtro) os Players VIP's na base de dados: " + ex.Message);
            }
        }

        public int InserirPlayerVip(PlayersVip playersVip)
        {
            try
            {
                using (var con = new SQLiteConnection(_conStringDB))
                {
                    using (var cmd = new SQLiteCommand(con))
                    {
                        cmd.CommandText = "INSERT INTO TB_COESERVER_PLAYERS_VIP(PLAYER_NOME, PLAYER_NICK, PLAYER_DT_INCLUSAO_SLOT_VIP, PLAYER_ATIVO, PLAYER_EH_ADMIN, PLAYER_DIAS_VIP) " +
                                          "VALUES(@PLAYER_NOME, @PLAYER_NICK, " +
                                          "@PLAYER_DT_INCLUSAO_SLOT_VIP, @PLAYER_ATIVO, @PLAYER_EH_ADMIN, @PLAYER_DIAS_VIP);";

                        cmd.Parameters.AddWithValue("PLAYER_NOME", playersVip.PlayerNome);
                        cmd.Parameters.AddWithValue("PLAYER_NICK", playersVip.PlayerNick);
                        cmd.Parameters.AddWithValue("PLAYER_DT_INCLUSAO_SLOT_VIP", playersVip.PlayerDataInclusaoSLOTVip);
                        cmd.Parameters.AddWithValue("PLAYER_ATIVO", playersVip.PlayerAtivo);
                        cmd.Parameters.AddWithValue("PLAYER_EH_ADMIN", playersVip.PlayerEhAdmin);
                        cmd.Parameters.AddWithValue("PLAYER_DIAS_VIP", playersVip.PlayerDiasVIP);

                        cmd.CommandType = System.Data.CommandType.Text;

                        if (con.State == System.Data.ConnectionState.Closed)
                            con.Open();

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir o Player VIP na base de dados: " + ex.Message);
            }
        }

        public int EditarPlayerVip(PlayersVip playersVip)
        {
            try
            {
                using (var con = new SQLiteConnection(_conStringDB))
                {
                    using (var cmd = new SQLiteCommand(con))
                    {
                        cmd.CommandText = "UPDATE TB_COESERVER_PLAYERS_VIP SET " +
                                          "PLAYER_NOME = @PLAYER_NOME, " +
                                          "PLAYER_NICK = @PLAYER_NICK, " +
                                          "PLAYER_DT_INCLUSAO_SLOT_VIP = @PLAYER_DT_INCLUSAO_SLOT_VIP, " +
                                          "PLAYER_ATIVO = @PLAYER_ATIVO, " +
                                          "PLAYER_EH_ADMIN = @PLAYER_EH_ADMIN, " +
                                          "PLAYER_DIAS_VIP = @PLAYER_DIAS_VIP " +
                                          "WHERE PLAYER_ID = @PLAYER_ID;";

                        cmd.Parameters.AddWithValue("PLAYER_NOME", playersVip.PlayerNome);
                        cmd.Parameters.AddWithValue("PLAYER_NICK", playersVip.PlayerNick);
                        cmd.Parameters.AddWithValue("PLAYER_DT_INCLUSAO_SLOT_VIP", playersVip.PlayerDataInclusaoSLOTVip);
                        cmd.Parameters.AddWithValue("PLAYER_ATIVO", playersVip.PlayerAtivo);
                        cmd.Parameters.AddWithValue("PLAYER_EH_ADMIN", playersVip.PlayerEhAdmin);
                        cmd.Parameters.AddWithValue("PLAYER_DIAS_VIP", playersVip.PlayerDiasVIP);
                        cmd.Parameters.AddWithValue("PLAYER_ID", playersVip.PlayerID);

                        cmd.CommandType = System.Data.CommandType.Text;

                        if (con.State == System.Data.ConnectionState.Closed)
                            con.Open();

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao editar o Players VIP na base de dados: " + ex.Message);
            }
        }

        public int DeletarPlayerVip(int id)
        {
            try
            {
                using (var con = new SQLiteConnection(_conStringDB))
                {
                    using (var cmd = new SQLiteCommand(con))
                    {
                        cmd.CommandText = string.Format("DELETE FROM TB_COESERVER_PLAYERS_VIP WHERE PLAYER_ID = {0};", id);
                        cmd.CommandType = System.Data.CommandType.Text;

                        if (con.State == System.Data.ConnectionState.Closed)
                            con.Open();

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir o Players VIP na base de dados: " + ex.Message);
            }
        }

        // ACESSOS ADMINISTRAÇÃO SISTEMA
        public AdministracaoPlayersVip LoginAdministracao(AdministracaoPlayersVip administracaoPlayersVip)
        {
            try
            {
                using (var con = new SQLiteConnection(_conStringDB))
                {
                    using (var cmd = new SQLiteCommand(con))
                    {
                        cmd.CommandText = "SELECT ADM.ADMIN_ID, ADM.LEVEL_ADMIN_ID, ADM.ADMIN_NOME, ADM.ADMIN_LOGIN, LVL_ADM.LEVEL_ADMIN_ID, LVL_ADM.LEVEL_ADMIN_DESCRICAO " +
                                          "FROM TB_COESERVER_ADMIN AS ADM " +
                                          "INNER JOIN TB_LEVEL_ADMIN AS LVL_ADM ON ADM.LEVEL_ADMIN_ID = LVL_ADM.LEVEL_ADMIN_ID " +
                                          "WHERE ADM.ADMIN_LOGIN = @ADMIN_LOGIN AND ADM.ADMIN_PASSWORD = @ADMIN_PASSWORD;";

                        cmd.Parameters.AddWithValue("ADMIN_LOGIN", administracaoPlayersVip.AdminLogin);
                        cmd.Parameters.AddWithValue("ADMIN_PASSWORD", administracaoPlayersVip.AdminPassword);

                        cmd.CommandType = System.Data.CommandType.Text;

                        if (con.State == System.Data.ConnectionState.Closed)
                            con.Open();

                        SQLiteDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                            return AdministracaoPlayersVipTranslate.MapFromReader(reader);
                        else
                            return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar usuário de administracão de Players VIP na base de dados: " + ex.Message);
            }
        }

        public int InserirUsuarioSistema(AdministracaoPlayersVip administracaoPlayersVip)
        {
            try
            {
                using (var con = new SQLiteConnection(_conStringDB))
                {
                    using (var cmd = new SQLiteCommand(con))
                    {
                        cmd.CommandText = "INSERT INTO TB_COESERVER_ADMIN(LEVEL_ADMIN_ID, ADMIN_NOME, ADMIN_LOGIN, ADMIN_PASSWORD, ADMIN_DATA_CADASTRO) " +
                                          "VALUES(@LEVEL_ADMIN_ID, @ADMIN_NOME, @ADMIN_LOGIN, @ADMIN_PASSWORD, @ADMIN_DATA_CADASTRO)";

                        cmd.Parameters.AddWithValue("LEVEL_ADMIN_ID", administracaoPlayersVip.LvlAdminID);
                        cmd.Parameters.AddWithValue("ADMIN_NOME", administracaoPlayersVip.AdminNome);
                        cmd.Parameters.AddWithValue("ADMIN_LOGIN", administracaoPlayersVip.AdminLogin);
                        cmd.Parameters.AddWithValue("ADMIN_PASSWORD", administracaoPlayersVip.AdminPassword);
                        cmd.Parameters.AddWithValue("ADMIN_DATA_CADASTRO", administracaoPlayersVip.AdminDataCadastro);

                        cmd.CommandType = System.Data.CommandType.Text;

                        if (con.State == System.Data.ConnectionState.Closed)
                            con.Open();

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir o Usuário de Sistema na base de dados: " + ex.Message);
            }
        }

        public List<AdministracaoPlayersVip> GetUsuariosSistemaAll()
        {
            try
            {
                using (var con = new SQLiteConnection(_conStringDB))
                {
                    using (var cmd = new SQLiteCommand(con))
                    {
                        cmd.CommandText = "SELECT * FROM TB_COESERVER_ADMIN AS ADM " +
                                          "INNER JOIN TB_LEVEL_ADMIN AS LVL_ADM ON ADM.LEVEL_ADMIN_ID = LVL_ADM.LEVEL_ADMIN_ID;";
                        cmd.CommandType = System.Data.CommandType.Text;

                        if (con.State == System.Data.ConnectionState.Closed)
                            con.Open();

                        SQLiteDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                            return AdministracaoPlayersVipTranslate.MapFromReaderList(reader);
                        else
                            return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar os Players VIP's na base de dados: " + ex.Message);
            }
        }

        public int DeletarUsuarioSistema(int id)
        {
            try
            {
                using (var con = new SQLiteConnection(_conStringDB))
                {
                    using (var cmd = new SQLiteCommand(con))
                    {
                        cmd.CommandText = "DELETE FROM TB_COESERVER_ADMIN AS ADM WHERE ADM.ADMIN_ID = @ADMIN_ID";

                        cmd.Parameters.AddWithValue("ADMIN_ID", id);

                        cmd.CommandType = System.Data.CommandType.Text;

                        if (con.State == System.Data.ConnectionState.Closed)
                            con.Open();

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir o Usuário de Sistema na base de dados: " + ex.Message);
            }
        }

        public int AlterarUsuarioSistema(int id, bool ehAdmin)
        {
            try
            {
                using (var con = new SQLiteConnection(_conStringDB))
                {
                    using (var cmd = new SQLiteCommand(con))
                    {
                        cmd.CommandText = "UPDATE TB_COESERVER_ADMIN SET LEVEL_ADMIN_ID = @LEVEL_ADMIN_ID WHERE ADMIN_ID = @ADMIN_ID";

                        cmd.Parameters.AddWithValue("ADMIN_ID", id);
                        cmd.Parameters.AddWithValue("LEVEL_ADMIN_ID", ehAdmin == true ? 1 : 2);

                        cmd.CommandType = System.Data.CommandType.Text;

                        if (con.State == System.Data.ConnectionState.Closed)
                            con.Open();

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar o Usuário de Sistema na base de dados: " + ex.Message);
            }
        }
    }
}
