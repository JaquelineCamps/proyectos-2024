using System.ComponentModel.DataAnnotations;

namespace proyecto_final.models
{
    public class Alquiler
    {
        [Key]
        public int IdAlquiler { get; set; }
        public string Codigo { get; set; }
        public string Cliente { get; set; }
        public string Pelicula { get; set; }
        public string Fechaalquiler { get; set; }
        public string Fechadevolucion { get; set; }
    } 
}
