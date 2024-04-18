using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS.MODELOS
{
     public class CATEGORIA
    {
        [Key]
        public int CATEGORIAId { get; set; }

        [Required]
        [StringLength(50)]
        public string Codigo { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        [Required]
        public bool Estado { get; set; }




    }
}
