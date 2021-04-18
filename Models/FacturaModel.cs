using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PtoyectoFinal.Models
{
    public class FacturaModel
    {
        public string ID_Factura { get; set; }
        public string ID_Institucion { get; set; }
        public string ID_Cliente { get; set; }
        public string ID_Vehiculo { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Apellido_Cliente { get; set; }
        public string Cedula_Cliente { get; set; }
        public string Fecha_Inc { get; set; }
        public string Fecha_Fin { get; set; }
        public double Monto_paar { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string Tipo { get; set; }
        public string Matricula { get; set; }
        public int pago { get; set; }
    }
}
