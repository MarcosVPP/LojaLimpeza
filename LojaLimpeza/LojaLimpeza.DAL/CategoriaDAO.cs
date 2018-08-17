﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza.DAL
{
    public class CategoriaDAO
    {
        private List<Domain.Categoria> categorias;

        public CategoriaDAO()
        {
            this.categorias = new List<Domain.Categoria>();
            categorias.Add(new Domain.Categoria(1, "Cozinha"));
            categorias.Add(new Domain.Categoria(2, "Vidros"));
            categorias.Add(new Domain.Categoria(3, "Banheiro"));
        }
        

        public void Salvar(Domain.Categoria categoria)
        {
            var categoriaSalva = Obter(categoria.Codigo);

            if (categoriaSalva == null)
                this.categorias.Add(categoria);
            else
                categoriaSalva.Nome = categoria.Nome;
        }

        public List<Domain.Categoria> Listar()
        {
            return categorias;
        }

        public Domain.Categoria Obter(int codigo)
        {
            return categorias.Where(c => c.Codigo == codigo).FirstOrDefault();
        }

        public void Excluir(int codigo)
        {
            var categoriaAExcluir = Obter(codigo);
            this.categorias.Remove(categoriaAExcluir);
        }
    }
}