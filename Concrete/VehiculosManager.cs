using PtoyectoFinal.Contracts;
using PtoyectoFinal.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace PtoyectoFinal.Concrete
{
    public class VehiculosManager : IVehiculosManager
    {
        private readonly IDapperManager _dapperManager;

        public VehiculosManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public Task<int> Create(Vehiculos vehiculo)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Marca", vehiculo.Marca, DbType.String);
            dbPara.Add("ID_Institucion", vehiculo.ID_Institucion, DbType.String);
            dbPara.Add("Modelo", vehiculo.Modelo, DbType.String);
            dbPara.Add("Año", vehiculo.Año, DbType.String);
            dbPara.Add("Color", vehiculo.Color, DbType.String);
            dbPara.Add("Precio_Dia", vehiculo.Precio_Dia, DbType.Double);
            dbPara.Add("Tipo", vehiculo.Tipo, DbType.String);
            dbPara.Add("Capacidad_Carga", vehiculo.Capacidad_Carga, DbType.Double);
            dbPara.Add("Pasajeros", vehiculo.Pasajeros, DbType.Int32);
            dbPara.Add("Matricula", vehiculo.Matricula, DbType.String);
            dbPara.Add("NO_Seguro", vehiculo.No_Seguro, DbType.String);
            dbPara.Add("Foto", vehiculo.Foto, DbType.String);
            dbPara.Add("Generado", vehiculo.Generado, DbType.Double);
            dbPara.Add("Veces_Reservados", vehiculo.Veces_Reservados, DbType.Int32);
            dbPara.Add("Latitud", vehiculo.Latitud, DbType.Double);
            dbPara.Add("Longitud", vehiculo.Longitud, DbType.Double);
            dbPara.Add("Estado", vehiculo.Estado, DbType.String);
            var VehiculoID = Task.FromResult(_dapperManager.Insert<int>("[dbo].[SP_Add_Vehiculos]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return VehiculoID;
        }

        public Task<Vehiculos> GetById(int id, string Id_institucion)
        {
            var vehiculos = Task.FromResult(_dapperManager.Get<Vehiculos>($"select * from [Vehiculos] where ID = {id} AND ID_Institucion = '{Id_institucion}'", null,
                    commandType: CommandType.Text));
            return vehiculos;
        }

        public Task<List<Vehiculos>> ListAll(string id_institucion)
        {
            var vehiculos = Task.FromResult(_dapperManager.GetAll<Vehiculos>
                ($"SELECT * FROM [Vehiculos] WHERE ID_Institucion = '{id_institucion}' AND Estado = 'Habilitado'", null, commandType: CommandType.Text));
            return vehiculos;
        }

        public Task<List<Factura>> ListarReservasVehiculo(string id_institucion, string id_vehiculo)
        {
            var reservavehiculo = Task.FromResult(_dapperManager.GetAll<Factura>
                ($"SELECT TOP 3 * FROM [Factura] WHERE ID_Institucion = '{id_institucion}' AND ID_Vehiculo = '{id_vehiculo}' ORDER BY ID_Factura", null, commandType: CommandType.Text));
            return reservavehiculo;
        }


        public Task<List<Vehiculos>> ListarVehiculosDeshabilitados(string id_institucion)
        {
            var vehiculos = Task.FromResult(_dapperManager.GetAll<Vehiculos>
                ($"SELECT * FROM [Vehiculos] WHERE ID_Institucion = '{id_institucion}' AND Estado = 'Deshabilitado'", null, commandType: CommandType.Text));
            return vehiculos;
        }

        public Task<int> Delete(int id, string id_institucion)
        {
            var deleteVehiculos = Task.FromResult(_dapperManager.Execute($"Delete [Vehiculos] where ID = {id} AND ID_Institucion = '{id_institucion}'", null,
                    commandType: CommandType.Text));
            return deleteVehiculos;
        }

        public Task<int> Update(Vehiculos vehiculo)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("id", vehiculo.ID);
            dbPara.Add("Marca", vehiculo.Marca, DbType.String);
            dbPara.Add("Modelo", vehiculo.Modelo, DbType.String);
            dbPara.Add("Año", vehiculo.Año, DbType.String);
            dbPara.Add("Color", vehiculo.Color, DbType.String);
            dbPara.Add("Precio_Dia", vehiculo.Precio_Dia, DbType.Double);
            dbPara.Add("Tipo", vehiculo.Tipo, DbType.String);
            dbPara.Add("Capacidad_Carga", vehiculo.Capacidad_Carga, DbType.Double);
            dbPara.Add("Pasajeros", vehiculo.Pasajeros, DbType.Int32);
            dbPara.Add("Matricula", vehiculo.Matricula, DbType.String);
            dbPara.Add("NO_Seguro", vehiculo.No_Seguro, DbType.String);
            dbPara.Add("Foto", vehiculo.Foto, DbType.String);
            dbPara.Add("Latitud", vehiculo.Latitud, DbType.Double);
            dbPara.Add("Longitud", vehiculo.Longitud, DbType.Double);

            var updateVehiculos = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_Vehiculos]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateVehiculos;
        }

        public Task<int> DeshabilitarVehiculo(Vehiculos vehiculo)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", vehiculo.ID);
            dbPara.Add("Estado", vehiculo.Estado, DbType.String);

            var updateVehiculosEstado = Task.FromResult(_dapperManager.Update<int>("[dbo].[Update_Vehiculo_Estado]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateVehiculosEstado;
        }
        public Task<int> Generado(int id, double generado)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", id);
            dbPara.Add("Generado",generado, DbType.Double);

            var updateVehiculosEstado = Task.FromResult(_dapperManager.Update<int>("[dbo].[Update_Vehiculo_Generado]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateVehiculosEstado;
        }  
        public Task<int> Reservado(int id, int reservado)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", id);
            dbPara.Add("Veces_Reservados",reservado, DbType.Int32);

            var updateVehiculosEstado = Task.FromResult(_dapperManager.Update<int>("[dbo].[Update_Vehiculo_Reservado]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateVehiculosEstado;
        }

    }
}
