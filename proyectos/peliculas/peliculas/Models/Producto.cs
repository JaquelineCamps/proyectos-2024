using System.ComponentModel.DataAnnotations;

namespace peliculas.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string presentacion { get; set; }
        public decimal precio { get; set; }
        public string stock { get; set; }
    }
}
