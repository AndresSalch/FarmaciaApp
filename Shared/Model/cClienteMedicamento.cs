using System.ComponentModel.DataAnnotations;

namespace Shared.Model
{
    public class cClienteMedicamento
    {
        [Key]
        public int Identificacion { get; set; } = 0;
        [Key]
        public int IdMedicamento { get; set; } = 0;
        [Required]
        public string Dosis { get; set; } = string.Empty;
    }
}
