using System.ComponentModel.DataAnnotations;

namespace Shared.Model
{
    public class cClienteFarmacia
    {
        [Key]
        public int identificacion { get; set; } = 0;
        [Required]
        public String nombre { get; set; } = string.Empty;
        [Required]
        public DateTime fechanacimiento { get; set; } = DateTime.MinValue;
        [Required]
        public String telefono { get; set; } = string.Empty;
        [Required]
        public String email { get; set; } = string.Empty;
        [Required]
        public String estado { get; set; } = String.Empty;
    }
}
