using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS.MODELOS
{
     public class CONDICIONDEPAGO
    {
        [Key]
        public int CondicionPagoId { get; set; }

        [Required]
        [MaxLength(15)]
        public string Codigo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Descripcion { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        public int Dias { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
