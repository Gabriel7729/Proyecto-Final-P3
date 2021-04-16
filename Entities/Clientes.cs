using System;
using System.ComponentModel.DataAnnotations;

namespace PtoyectoFinal.Entities
{
    public class Clientes
    {
        [Key]
        public int ID { get; set; }
        public string Cedula { get; set; }
        public string ID_Institucion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Licencia { get; set; }
        public string Nacionalidad { get; set; }
        public string Tipo_Sangre { get; set; }
        public string Foto_Persona { get; set; }
        public string Foto_Licencia { get; set; }
        public string Estado { get; set; }
    }
}
