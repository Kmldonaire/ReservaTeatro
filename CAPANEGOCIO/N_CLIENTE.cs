using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPANEGOCIO
{
    internal class N_CLIENTE
    {

        Repository<Cliente> _repository;


        public N_Cliente()
        {
            _repository = new Repository<Cliente>();
        }

        public List<Cliente> ObtenerTodosLosCliente()
        {
            return _repository.Consulta().ToList();
        }

        public int AgregarCliente(Cliente cliente)
        {
            cliente.FechaCreacion = DateTime.Now;
            _repository.Agregar(cliente);
            return 1;
        }

        public int EditarCliente(Cliente cliente)
        {
            var clienteEnDB = _repository.Consulta().FirstOrDefault(c => c.ClienteId == cliente.ClienteId);

            if (clienteEnDB != null)
            {
                clienteEnDB.Codigo = cliente.Codigo;
                clienteEnDB.Nombres = cliente.Nombres;
                clienteEnDB.Apellidos = cliente.Apellidos;
                clienteEnDB.GrupoDescuentoId = cliente.GrupoDescuentoId;
                clienteEnDB.CondicionPagoId = cliente.CondicionPagoId;
                clienteEnDB.Estado = cliente.Estado;
                _repository.Editar(clienteEnDB);
                return 1;
            }
            return 0;
        }

        public int EliminarCliente(int clienteId)
        {
            var clienteEnDB = _repository.Consulta().FirstOrDefault(c => c.ClienteId == clienteId);
            if (clienteEnDB != null)
            {
                _repository.Eliminar(clienteEnDB);
                return 1;
            }
            return 0;
        }
    }
}
