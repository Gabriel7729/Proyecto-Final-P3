using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PtoyectoFinal.Models
{
    public class ReservaModel
    {
        public string ID_Cliente { get; set; }
        public string ID_Institucion { get; set; }
        public string ID_Vehiculo { get; set; }
        public string Fecha_Inc { get; set; }
        public string Fecha_Fin { get; set; }
    }
}
