using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class D_ROLES
    {
        var rolEnDB = _repository.Consulta().FirstOrDefault(r => r.RolID == rol.RolID);

            if (rolEnDB != null)
            {
                rolEnDB.NombreRol = rol.NombreRol;
                rolEnDB.Descripcion = rol.Descripcion;
                rolEnDB.FechaModificacion = DateTime.Now;
                rolEnDB.UsuarioModifica = rol.UsuarioModifica;
                rolEnDB.Estado = rol.Estado;
                _repository.Editar(rolEnDB);
                return 1;
            }
            return 0;
        }

public int EliminarRol(int rolId)
{
    var rolEnDB = _repository.Consulta().FirstOrDefault(r => r.RolID == rolId);
    if (rolEnDB != null)
    {
        _repository.Eliminar(rolEnDB);
        return 1;
    }
    return 0;
}
    }
}
