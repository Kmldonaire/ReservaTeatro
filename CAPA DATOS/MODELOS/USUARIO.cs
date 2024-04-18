using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS.MODELOS
{
    public class USUARIO
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(50)]
        public string Contraseña { get; set; }

        [Required]
        [StringLength(100)]
        public string Correo { get; set; }

        [Required]
        public int RolID { get; set; }

        [ForeignKey("RolID")]
        public Roles Rol { get; set; }

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
