using System;
using System.ComponentModel.DataAnnotations;

namespace PtoyectoFinal.Entities
{
    public class Vehiculos
    {
        [Key]
        public int ID { get; set; }
        public string Marca { get; set; }
        public string ID_Institucion { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public string Color { get; set; }
        public double Precio_Dia { get; set; }
        public string Tipo { get; set; }
        public double Capacidad_Carga { get; set; }
        public int Pasajeros { get; set; }
        public string Matricula { get; set; }
        public string No_Seguro { get; set; }
        public string Foto { get; set; }
        public double Generado { get; set; }
        public int Veces_Reservados { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Estado { get; set; }
    }
}
