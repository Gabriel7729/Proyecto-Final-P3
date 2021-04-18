using PtoyectoFinal.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PtoyectoFinal.Contracts
{
    public interface IReservaManager
    {
        Task<int> Agregar(Reservas reservas);
        Task<int> AgregarFactura(Factura factura);
        Task<List<Factura>> ListAll(string id_institucion);
        Task<int> ValidadFecha(string fechaI, string FechaF, string idI,string VID);
        Task<int> AltualizarPago(string id, double pago);
    }
}
