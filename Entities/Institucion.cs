using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PtoyectoFinal.Entities
{
    public class Institucion
    {
        [Key]
        public int ID_Institucion { get; set; }
        public string Nombre { get; set; }
        public string ID_login { get; set; }
    }
}
