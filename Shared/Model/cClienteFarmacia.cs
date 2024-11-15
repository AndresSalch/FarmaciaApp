using System.ComponentModel.DataAnnotations;

namespace Shared.Model
{
    public class cClienteFarmacia
    {
        [Key]
        public int Identificacion { get; set; } = 0;
        [Required]
        public String Nombre { get; set; } = string.Empty;
        [Required]
        public DateTime FechaNacimiento { get; set; } = DateTime.MinValue;
        [Required]
        public String Telefono { get; set; } = string.Empty;
        [Required]
        public String Email { get; set; } = string.Empty;
        [Required]
        public String Estado { get; set; } = String.Empty;
    }
}
