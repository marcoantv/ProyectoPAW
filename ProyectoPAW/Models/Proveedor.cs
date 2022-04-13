using System.ComponentModel.DataAnnotations;

namespace ProyectoPAW2.Models
{
    public class Proveedor
    {
        [Key]
        public int IdProve { get; set; }
        [Required]
        public string NombreProveedor { get; set; }
        [Required]
        public int NumeroProveedor { get; set; }

        public string Correo { get; set; }
        [Required]
        public string NombreCompania { get; set; }
        [Required]
        public string DireccionExact { get; set; }
        [Required]
        public string Pais { get; set; }

        public string Provincia { get; set; }

        public string Canton { get; set; }

        public string Districto { get; set; }

    }
}
