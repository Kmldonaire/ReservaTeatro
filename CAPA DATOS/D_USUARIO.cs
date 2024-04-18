using CAPA_DATOS.MODELOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class D_USUARIO
    {
        var usuarioEnDB = _repository.Consulta().FirstOrDefault(u => u.ID == usuario.ID);

            if (usuarioEnDB != null)
            {
                usuarioEnDB.Nombre = usuario.Nombre;
                usuarioEnDB.Apellido = usuario.Apellido;
                usuarioEnDB.Contraseña = usuario.Contraseña;
                usuarioEnDB.Correo = usuario.Correo;
                usuarioEnDB.RolID = usuario.RolID;
                usuarioEnDB.FechaModificacion = DateTime.Now;
                usuarioEnDB.UsuarioModifica = " michelle";
                usuarioEnDB.Estado = usuario.Estado;
                _repository.Editar(usuarioEnDB);
                return 1;
            }
            return 0;
        }

public int EliminarUsuario(int usuarioId)
{
    var usuarioEnDB = _repository.Consulta().FirstOrDefault(u => u.ID == usuarioId);
    if (usuarioEnDB != null)
    {
        _repository.Eliminar(usuarioEnDB);
        return 1;
    }
    return 0;
}


    }
}
