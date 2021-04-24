using PtoyectoFinal.Contracts;
using PtoyectoFinal.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace PtoyectoFinal.Concrete
{
    public class ArticleManager : IArticleManager
    {
        private readonly IDapperManager _dapperManager;

        public ArticleManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        //ESTE ES EL DEL LOGIN
        public Task<int> Createlogin(login log)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("UserID", log.UserID, DbType.String);
            dbPara.Add("passID", log.passID, DbType.String);
            var articleId = Task.FromResult(_dapperManager.Insert<int>("[dbo].[Add_login]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return articleId;
        }
        //ESTE ES EL QUE CREA LA INSTITUCION
        public Task<int> CreateInst(Institucion inst)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Nombre", inst.Nombre, DbType.String);
            dbPara.Add("ID_login", inst.ID_login, DbType.String);
            var articleId = Task.FromResult(_dapperManager.Insert<int>("[dbo].[Add_Institucion]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return articleId;
        }
        //ESTE OBTINE EL ID DEL LOGIN
        public Task<string> getloginID(string UserID, string passID )
        {
            var article = Task.FromResult(_dapperManager.Get<string>($"select ID_login from [login] where UserID = '{UserID}' and passID = '{passID}' ", null,
                    commandType: CommandType.Text));
            return article;
        }
        //ESTE VERIFICA SI EXISTE USUARIO
        public Task<string> UserExiste(string UserID)
        {
            var article = Task.FromResult(_dapperManager.Get<string>($"select * from [login] where UserID = '{UserID}'", null,
                    commandType: CommandType.Text));
            return article;
        }
        //ESTE OBTIENE EL NOMBRE DE LA INSTITUCION LOGEADA
        public Task<string> getIDCompani(string ID_login)
        {
            var article = Task.FromResult(_dapperManager.Get<string>($"select ID_Institucion from [Institucion] where ID_login = '{ID_login}'", null,
                    commandType: CommandType.Text));
            return article;
        }
    }
}
