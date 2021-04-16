using PtoyectoFinal.Contracts;
using PtoyectoFinal.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace PtoyectoFinal.Concrete
{
    public class ClientesManager : IClientesManager
    {
        private readonly IDapperManager _dapperManager;

        public ClientesManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        //Metodo para agregar cada uno de los campos en la tabla de CLientes de la base de datos
        public Task<int> Create(Clientes cliente)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Cedula", cliente.Cedula, DbType.String);
            dbPara.Add("ID_Institucion", cliente.ID_Institucion, DbType.String);
            dbPara.Add("Nombre", cliente.Nombre, DbType.String);
            dbPara.Add("Apellido", cliente.Apellido, DbType.String);
            dbPara.Add("Correo", cliente.Correo, DbType.String);
            dbPara.Add("Licencia", cliente.Licencia, DbType.String);
            dbPara.Add("Nacionalidad", cliente.Nacionalidad, DbType.String);
            dbPara.Add("Tipo_Sangre", cliente.Tipo_Sangre, DbType.String);
            dbPara.Add("Foto_Persona", cliente.Foto_Persona, DbType.String);
            dbPara.Add("Foto_Licencia", cliente.Foto_Licencia, DbType.String);
            dbPara.Add("Estado", cliente.Estado, DbType.String);
            var ClienteID = Task.FromResult(_dapperManager.Insert<int>("[dbo].[SP_Add_Clientes]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return ClienteID;
        }

        //Metodo que obtiene el ID de un cliente determinado
        public Task<Clientes> GetById(int id, string Id_institucion)
        {
            var clientes = Task.FromResult(_dapperManager.Get<Clientes>($"select * from [Clientes] where ID = {id} AND ID_Institucion = '{Id_institucion}'", null,
                    commandType: CommandType.Text));
            return clientes;
        }

        //Metodo que obtiene una lista de todos los clientes habilitados de la empresa, que recibe por parametros el id de la institucion
        public Task<List<Clientes>> ListarClientes(string id_institucion)
        {
            var clientes = Task.FromResult(_dapperManager.GetAll<Clientes>
                ($"SELECT * FROM [Clientes] WHERE ID_Institucion = '{id_institucion}' AND Estado = 'Habilitado'", null, commandType: CommandType.Text));
            return clientes;
        }

        //Metodo que obtiene una lista de todos los clientes deshabilitados de la empresa, que recibe por parametros el id de la institucion
        public Task<List<Clientes>> ListarClientesDeshabilitados(string id_institucion)
        {
            var clientes = Task.FromResult(_dapperManager.GetAll<Clientes>
                ($"SELECT * FROM [Clientes] WHERE ID_Institucion = '{id_institucion}' AND Estado = 'Deshabilitado'", null, commandType: CommandType.Text));
            return clientes;
        }

        //Metodo que borra a un cliente, dependiendo del ID que se le pase por parametro y de la institucion
        public Task<int> Delete(int id, string id_institucion)
        {
            var deleteClientes = Task.FromResult(_dapperManager.Execute($"Delete [Clientes] where ID = {id} AND ID_Institucion = '{id_institucion}'", null,
                    commandType: CommandType.Text));
            return deleteClientes;
        }

        //Metodo para actualziar los campos de la tabla 'Clientes' de la base de datos
        public Task<int> Update(Clientes cliente)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("id", cliente.ID);
            dbPara.Add("Cedula", cliente.Cedula, DbType.String);
            dbPara.Add("Nombre", cliente.Nombre, DbType.String);
            dbPara.Add("Apellido", cliente.Apellido, DbType.String);
            dbPara.Add("Correo", cliente.Correo, DbType.String);
            dbPara.Add("Licencia", cliente.Licencia, DbType.String);
            dbPara.Add("Nacionalidad", cliente.Nacionalidad, DbType.String);
            dbPara.Add("Tipo_Sangre", cliente.Tipo_Sangre, DbType.String);
            dbPara.Add("Foto_Persona", cliente.Foto_Persona, DbType.String);
            dbPara.Add("Foto_Licencia", cliente.Foto_Licencia, DbType.String);

            var updateClientes = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_Clientes]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateClientes;
        }

        public Task<int> DeshabilitarCliente(Clientes cliente)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", cliente.ID);
            dbPara.Add("Estado", cliente.Estado, DbType.String);

            var updateClienteEstado = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_Clientes_Estado]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateClienteEstado;
        }

        public Task<int> HabilitarCliente(Clientes cliente)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", cliente.ID);
            dbPara.Add("Estado", cliente.Estado, DbType.String);

            var updateClienteEstado = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_Clientes_Estado]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateClienteEstado;
        }

    }
}
