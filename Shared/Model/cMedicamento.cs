using System.ComponentModel.DataAnnotations;

namespace Shared.Model
{
    public class cMedicamento
    {
        [Key]
        public int IdMedicamento { get; set; } = 0;
        [Required]
        public String Descripcion { get; set; } = string.Empty;
        [Required]
        public String Presentacion {  get; set; } = string.Empty;
        [Required]
        public String Marca { get; set;} = string.Empty;
        [Required]
        public String Estado { get; set; } = string.Empty;
    }
}
