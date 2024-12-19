using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Model.DTO
{
    public class dtoMedicamento
    {
        [Required]
        public String descripcion { get; set; } = string.Empty;
        [Required]
        public String presentacion { get; set; } = string.Empty;
        [Required]
        public String marca { get; set; } = string.Empty;
        [Required]
        public String estado { get; set; } = string.Empty;
    }
}
