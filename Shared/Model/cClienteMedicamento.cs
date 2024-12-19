using System.ComponentModel.DataAnnotations;

namespace Shared.Model
{
    public class cClienteMedicamento
    {
        [Key]
        public int identificacion { get; set; } = 0;
        [Key]
        public int idmedicamento { get; set; } = 0;
        [Required]
        public string dosis { get; set; } = string.Empty;
    }
}
