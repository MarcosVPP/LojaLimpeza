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
<<<<<<< HEAD
=======

>>>>>>> 1c77bc2e340aa8a4090a6b725b99b38340dda802
    }
 
}
