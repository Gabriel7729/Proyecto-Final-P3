using PtoyectoFinal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PtoyectoFinal.Contracts
{
    public interface IVehiculosManager
    {
        Task<int> Create(Vehiculos vehiculo);
        Task<int> Delete(int id, string id_institucion);
        Task<int> Update(Vehiculos vehiculo);
        Task<int> DeshabilitarVehiculo(Vehiculos vehiculo);
        Task<int> Generado(int id, double generado);
        Task<int> Reservado(int id, int reservado);
        Task<Vehiculos> GetById(int Id, string Id_institucion);
        Task<List<Vehiculos>> ListAll(string id_institucion);
        Task<List<Vehiculos>> ListarVehiculosMapaModal(string id_institucion, string id_vehiculo);
        Task<List<Factura>> ListarReservasVehiculo(string id_institucion, string id_vehiculo);
        Task<List<Vehiculos>> ListarVehiculosDeshabilitados(string id_institucion);
    }
}
