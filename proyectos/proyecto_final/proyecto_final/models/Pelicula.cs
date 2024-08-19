using System.ComponentModel.DataAnnotations;

namespace proyecto_final.models
{
    public class Pelicula
    {

        [Key]
        public int IdPelicula { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string sinopsis { get; set; }
        public string duracion { get; set; }
        public string clasificacion { get; set; }
        
    }
}
