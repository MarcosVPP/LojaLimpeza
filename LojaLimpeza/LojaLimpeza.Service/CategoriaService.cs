using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza.Service
{
    public class CategoriaService
    {
        private DAL.CategoriaDAO categoriaDAO = new DAL.CategoriaDAO();

        public void Salvar(Domain.CategoriaDomain categoria)
        {
            categoriaDAO.Salvar(categoria);
        }

        public List<Domain.CategoriaDomain> Listar()
        {
            

            return categoriaDAO.Listar();
        }
    }
}
