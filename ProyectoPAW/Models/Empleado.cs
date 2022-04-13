using System.ComponentModel.DataAnnotations;

namespace ProyectoPAW2.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string PrimerApe { get; set; }
        
        public string SegundoApe { get; set; }
        [Required]
        public int Telefono { get; set; }

        public string Correo { get; set; }
        [Required]
        public decimal Sueldo { get; set; }
    }
}
