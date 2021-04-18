using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PtoyectoFinal.Contracts;
using PtoyectoFinal.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;


namespace PtoyectoFinal.Concrete
{
    public class ReservaManager : IReservaManager
    {
        private readonly IDapperManager _dapperManager;

        public ReservaManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        //
     

        //

        public Task<int> Agregar(Reservas reservas)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID_Cliente", reservas.ID_Cliente, DbType.String);
            dbPara.Add("ID_Institucion", reservas.ID_Institucion, DbType.String);
            dbPara.Add("ID_Vehiculo", reservas.ID_Vehiculo, DbType.String);
            dbPara.Add("Fecha_Inc", reservas.Fecha_Inc, DbType.String);
            dbPara.Add("Fecha_Fin", reservas.Fecha_Fin, DbType.String);
            var ReservaID = Task.FromResult(_dapperManager.Insert<int>("[dbo].[Add_Reserva]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return ReservaID;
        }
        public Task<int> AgregarFactura(Factura factura)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID_Institucion", factura.ID_Institucion, DbType.String);
            dbPara.Add("ID_Cliente", factura.ID_Cliente, DbType.String);
            dbPara.Add("ID_Vehiculo", factura.ID_Vehiculo, DbType.String);
            dbPara.Add("Nombre_Cliente", factura.Nombre_Cliente, DbType.String);
            dbPara.Add("Apellido_Cliente", factura.Apellido_Cliente, DbType.String);
            dbPara.Add("Cedula_Cliente", factura.Cedula_Cliente, DbType.String);
            dbPara.Add("Fecha_Inc", factura.Fecha_Inc, DbType.String);
            dbPara.Add("Fecha_Fin", factura.Fecha_Fin, DbType.String);
            dbPara.Add("Monto_pagar", factura.Monto_pagar, DbType.Double);
            dbPara.Add("Marca", factura.Marca, DbType.String);
            dbPara.Add("Color", factura.Color, DbType.String);
            dbPara.Add("Tipo", factura.Tipo, DbType.String);
            dbPara.Add("Matricula", factura.Matricula, DbType.String);
            dbPara.Add("pago", factura.pago, DbType.Int32);
            var ReservaID = Task.FromResult(_dapperManager.Insert<int>("[dbo].[Add_Factura]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return ReservaID;
        }

        public Task<int> ValidadFecha(string fechaI, string FechaF, string idI, string VID)
        {
            var article = Task.FromResult(_dapperManager.Get<int>($"select COUNT (*) from Reserva where Fecha_Inc >= '{fechaI}' AND Fecha_Fin <= '{FechaF}' OR Fecha_Inc = '{fechaI}' AND ID_Institucion = '{idI}' AND ID_Vehiculo = '{VID}'", null,
                    commandType: CommandType.Text));
            return article;
        }

        public Task<List<Factura>> ListAll(string id_institucion)
        {
            var vehiculos = Task.FromResult(_dapperManager.GetAll<Factura>
                ($"SELECT * FROM [Factura] WHERE ID_Institucion = '{id_institucion}'", null, commandType: CommandType.Text));
            return vehiculos;
        }

        public Task<int> AltualizarPago(string id, double pago)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("id", id);
            dbPara.Add("Monto_pagar", pago, DbType.Double);

            var updateClienteEstado = Task.FromResult(_dapperManager.Update<int>("[dbo].[Update_Pago_Factur]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateClienteEstado;
        }
    }
}
