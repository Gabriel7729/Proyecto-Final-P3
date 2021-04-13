using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PtoyectoFinal.Entities
{
    public class login
    {
        [Key]
        public int ID_login { get; set; }
        public string UserID { get; set; }
        public string passID { get; set; }
    }
}
