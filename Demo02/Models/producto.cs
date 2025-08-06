using System;
using System.ComponentModel.DataAnnotations;

namespace Demo02.Models
{
    public class producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal pvp { get; set; }
        public int stock { get; set; }
        public string categoria { get; set; }
        [DataType(DataType.Date)]
        public DateTime fecha_elaboracion { get; set; }
        [DataType(DataType.Date)]
        public DateTime fecha_caducidad { get; set; }
        public string descripcion { get; set; }
    }
}
