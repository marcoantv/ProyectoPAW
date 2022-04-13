using System.ComponentModel.DataAnnotations;

namespace ProyectoPAW2.Models
{
    public class Cliente
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

        public int TelefonoHogar { get; set; }

        public string Correo { get; set; }

        public string Pais { get; set; }
        [Required]
        public string DireccionExact { get; set; }

        public string Provincia { get; set; }

        public string Canton { get; set; }

        public string Districto { get; set; }
    }
}
