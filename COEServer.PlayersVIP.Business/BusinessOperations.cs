using COEServer.PlayersVIP.Common;
using COEServer.PlayersVIP.Common.Filters;
using COEServer.PlayersVIP.DataAccess;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace COEServer.PlayersVIP.Business
{
    public class BusinessOperations
    {
        #region Chamada para operações de base de dados
        OperationsDataBase _operationsDataBase;

        public PlayersVip BusinessGetPlayersVipById(int id)
        {
            _operationsDataBase = new OperationsDataBase();

            return _operationsDataBase.GetPlayersVipById(id);
        }

        public List<PlayersVip> BusinessGetPlayersVipAll()
        {
            _operationsDataBase = new OperationsDataBase();

            return _operationsDataBase.GetPlayersVipAll();
        }

        public List<PlayersVip> BusinessGetPlayersVipByFilter(PlayersVipFilter playersVipFilter)
        {
            _operationsDataBase = new OperationsDataBase();

            return _operationsDataBase.GetPlayersVipByFilter(playersVipFilter);
        }

        public bool BusinessInserirPlayerVip(PlayersVip playersVip)
        {
            _operationsDataBase = new OperationsDataBase();

            return _operationsDataBase.InserirPlayerVip(playersVip) > 0 ? true : false;
        }

        public bool BusinessEditarPlayerVip(PlayersVip playersVip)
        {
            _operationsDataBase = new OperationsDataBase();

            return _operationsDataBase.EditarPlayerVip(playersVip) > 0 ? true : false;
        }

        public bool BusinessDeletarPlayerVip(int id)
        {
            _operationsDataBase = new OperationsDataBase();

            return _operationsDataBase.DeletarPlayerVip(id) > 0 ? true : false;
        }

        public AdministracaoPlayersVip BusinessAdministracaoPlayersVip(AdministracaoPlayersVip administracaoPlayersVip)
        {
            _operationsDataBase = new OperationsDataBase();

            administracaoPlayersVip.AdminPassword = MD5Hash(administracaoPlayersVip.AdminPassword);

            return _operationsDataBase.LoginAdministracao(administracaoPlayersVip);
        }

        public bool BusinessInserirUsuarioSistema(AdministracaoPlayersVip administracaoPlayersVip)
        {
            _operationsDataBase = new OperationsDataBase();

            administracaoPlayersVip.AdminPassword = MD5Hash(administracaoPlayersVip.AdminPassword);

            return _operationsDataBase.InserirUsuarioSistema(administracaoPlayersVip) > 0 ? true : false;
        }

        public List<AdministracaoPlayersVip> BusinessGetUsuariosSistemaAll()
        {
            _operationsDataBase = new OperationsDataBase();

            return _operationsDataBase.GetUsuariosSistemaAll();
        }

        public bool BusinessDeletarUsuarioSistema(int id)
        {
            _operationsDataBase = new OperationsDataBase();

            return _operationsDataBase.DeletarUsuarioSistema(id) > 0 ? true : false;
        }

        public bool BusinesAlterarUsuarioSistema(int id, bool ehAdmin)
        {
            _operationsDataBase = new OperationsDataBase();

            return _operationsDataBase.AlterarUsuarioSistema(id, ehAdmin) > 0 ? true : false;
        }

        #endregion Chamada para operações de base de dados

        public static string MD5Hash(string pass)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass));
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
                strBuilder.Append(result[i].ToString("x2"));

            return strBuilder.ToString();
        }

        #region Chamada para operações de hash, cálculos etc

        #endregion Chamada para operações de hash, cálculos etc
    }
}