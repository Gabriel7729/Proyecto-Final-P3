using PtoyectoFinal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PtoyectoFinal.Contracts
{
    public interface IArticleManager
    {
        Task<int> Createlogin(login log); //4
        Task<int> CreateInst(Institucion inst); //1
        Task<string> getloginID(string UserID,string passID); //2
        Task<string> getIDCompani(string ID_login); //3
        Task<string> UserExiste(string UserID); //4
    }
}
