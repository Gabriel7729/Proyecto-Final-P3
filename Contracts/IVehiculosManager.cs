﻿using PtoyectoFinal.Entities;
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
        Task<Vehiculos> GetById(int Id, string Id_institucion);
        Task<List<Vehiculos>> ListAll(string id_institucion);
        Task<List<Vehiculos>> ListarVehiculosDeshabilitados(string id_institucion);
    }
}