using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS.MODELOS
{
     public class ROLES
    {
        [Key]
        public int RolID { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreRol { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        [Required]
        public DateTime FechaModificacion { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuarioCreador { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuarioModifica { get; set; }

        [Required]
        public bool Estado { get; set; }

    }
}
