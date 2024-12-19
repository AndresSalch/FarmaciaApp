using System.ComponentModel.DataAnnotations;

namespace Shared.Model
{
    public class cMedicamento
    {
        [Key]
        public int idmedicamento { get; set; } = 0;
        [Required]
        public String descripcion { get; set; } = string.Empty;
        [Required]
        public String presentacion {  get; set; } = string.Empty;
        [Required]
        public String marca { get; set;} = string.Empty;
        [Required]
        public String estado { get; set; } = string.Empty;
    }
}
