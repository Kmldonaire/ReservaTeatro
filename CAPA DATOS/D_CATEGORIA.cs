﻿using CAPA_DATOS.MODELOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS
{
    public class D_CATEGORIA
    {
        Repository<Categoria> _repository;
        public D_Categoria()
        {
            _repository = new Repository<Categoria>();
        }

        public List<Categoria> ObtenerTodalascategorias()
        {
            return _repository.Consulta().ToList();
        }

        public int AgregarCategoria(Categoria categoria)
        {
            categoria.FechaCreacion = DateTime.Now;
            _repository.Agregar(categoria);
            return 1;
        }

        public int EditarCategoria(Categoria categoria)
        {
            var categoriaEnDB = _repository.Consulta().FirstOrDefault(r => r.CategoriaId == categoria.CategoriaId);

            if (categoriaEnDB != null)
            {
                categoriaEnDB.Codigo = categoria.Codigo;
                categoriaEnDB.Descripcion = categoria.Descripcion;
                categoriaEnDB.Estado = categoria.Estado;
                _repository.Editar(categoriaEnDB);
                return 1;
            }
            return 0;
        }

        public int EliminarCategoria(int categoriaId)
        {
            var categoriaEnDB = _repository.Consulta().FirstOrDefault(r => r.CategoriaId == categoriaId);
            if (categoriaEnDB != null)
            {
                _repository.Eliminar(categoriaEnDB);
                return 1;
            }
            return 0;
        }
}
