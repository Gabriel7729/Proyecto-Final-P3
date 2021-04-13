using PtoyectoFinal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PtoyectoFinal.Contracts
{
    public interface IArticleManager
    {
        Task<int> Create(Article article);
        Task<int> Createlogin(login log); //4
        Task<int> CreateInst(Institucion inst); //1
        Task<string> getloginID(string UserID,string passID); //2
        Task<string> getIDCompani(string ID_login); //3
        Task<string> UserExiste(string UserID); //4
        Task<int> Delete(int Id);
        Task<int> Count(string search);
        Task<int> Update(Article article);
        Task<Article> GetById(int Id);
        Task<List<Article>> ListAll(int skip, int take, string orderBy, string direction, string search);
    }
}
