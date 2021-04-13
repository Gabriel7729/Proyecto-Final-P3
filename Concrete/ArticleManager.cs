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

        public Task<int> Create(Article article)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Title", article.Title, DbType.String);
            var articleId = Task.FromResult(_dapperManager.Insert<int>("[dbo].[SP_Add_Article]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return articleId;
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
        
        public Task<Article> GetById(int id)
        {
            var article = Task.FromResult(_dapperManager.Get<Article>($"select * from [Article] where ID = {id}", null,
                    commandType: CommandType.Text));
            return article;
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

        public Task<int> Delete(int id)
        {
            var deleteArticle = Task.FromResult(_dapperManager.Execute($"Delete [Article] where ID = {id}", null,
                    commandType: CommandType.Text));
            return deleteArticle;
        }

        public Task<int> Count(string search)
        {
            var totArticle = Task.FromResult(_dapperManager.Get<int>($"select COUNT(*) from [Article] WHERE Title like '%{search}%'", null,
                    commandType: CommandType.Text));
            return totArticle;
        }

        public Task<List<Article>> ListAll(int skip, int take, string orderBy, string direction = "DESC", string search = "")
        {
            var articles = Task.FromResult(_dapperManager.GetAll<Article>
                ($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return articles;
        }

        public Task<int> Update(Article article)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", article.ID);
            dbPara.Add("Title", article.Title, DbType.String);

            var updateArticle = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_Article]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateArticle;
        }
    }
}
