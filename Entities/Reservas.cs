using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.OData.Edm;

namespace PtoyectoFinal.Entities
{
    public class Reservas
    {

                [Key]
        public string ID_Cliente { get; set; }
        public string ID_Institucion { get; set; }
        public string ID_Vehiculo { get; set; }
        public string Fecha_Inc { get; set; }
        public string Fecha_Fin { get; set; }
    }
}
