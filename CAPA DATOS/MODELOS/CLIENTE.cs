using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS.MODELOS
{
     public class CLIENTE
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(15)]
        public string Codigo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombres { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellidos { get; set; }

        [Required]
        public int CondicionPagoId { get; set; }

        [ForeignKey("CondicionPagoId")]
        public CondicionPago condicionPago { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }



    }
}
