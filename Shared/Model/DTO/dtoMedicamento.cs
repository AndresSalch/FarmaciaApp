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
        public String Descripcion { get; set; } = string.Empty;
        [Required]
        public String Presentacion { get; set; } = string.Empty;
        [Required]
        public String Marca { get; set; } = string.Empty;
        [Required]
        public String Estado { get; set; } = string.Empty;
    }
}
