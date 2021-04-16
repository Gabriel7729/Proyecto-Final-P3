using PtoyectoFinal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PtoyectoFinal.Contracts
{
    public interface IClientesManager
    {
        Task<int> Create(Clientes cliente);
        Task<int> Delete(int id, string id_institucion);
        Task<int> Update(Clientes cliente);
        Task<int> DeshabilitarCliente(Clientes cliente);
        Task<int> HabilitarCliente(Clientes cliente);
        Task<Clientes> GetById(int Id, string Id_institucion);
        Task<List<Clientes>> ListarClientes(string id_institucion);
        Task<List<Clientes>> ListarClientesDeshabilitados(string id_institucion);
    }
}
