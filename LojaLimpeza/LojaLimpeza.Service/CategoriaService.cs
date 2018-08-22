using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaLimpeza.Domain;

namespace LojaLimpeza.Service
{
    public class CategoriaService
    {
        private DAL.CategoriaDAO categoriaDAO = new DAL.CategoriaDAO();

        public void Salvar(Domain.CategoriaDomain categoria) => categoriaDAO.Salvar(categoria);

        public List<Domain.CategoriaDomain> Listar()
        {
            return categoriaDAO.Listar();
        }

        public void Salvar(LojaLimpeza.Domain.CategoriaDomain categoria)
        {
            throw new NotImplementedException();
        }

        public void Salvar(LojaLimpeza.Domain.CategoriaDomain categoria)
        {
            throw new NotImplementedException();
        }
    }
 
}
