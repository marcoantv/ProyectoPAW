using System.ComponentModel.DataAnnotations;

namespace ProyectoPAW2.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        public string NombreProducto { get; set; }
        [Required]
        public decimal PrecioUni { get; set; }

        public string Descripcion { get; set; }
        [Required]
        public int Cantidad { get; set; }
    }
}
