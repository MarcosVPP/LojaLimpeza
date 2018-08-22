using LojaLimpeza.DAL.Infraestrutura;
using LojaLimpeza.Domain;
using NHibernate;
using System.Collections.Generic;
using System.Linq;

namespace LojaLimpeza.DAL
{
    public class CategoriaDAO
    {


        private List<Domain.CategoriaDomain> categorias;

        public CategoriaDAO()
        {
            this.categorias = new List<Domain.CategoriaDomain>();

        }

        public void Salvar(Domain.CategoriaDomain categoria)
        {
            var categoriaSalva = Obter(categoria.Codigo);

            if (categoriaSalva == null)
            {
                using (ISession session = AppSessionFactory.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    transaction.Begin();
                    session.Save(categoria);
                    transaction.Commit();
                    session.Close();
                }

            }

            else
            {
                categoriaSalva.Nome = categoria.Nome;
            }
        }

        public List<Domain.CategoriaDomain> Listar()
        {
            IList<Domain.CategoriaDomain> _categorias;
            return categorias;
        }

        public Domain.CategoriaDomain Obter(int codigo)
        {
            using (ISession session = AppSessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                transaction.Begin();
                session.Get(typeof(CategoriaDomain), 1);
                transaction.Commit();
                session.Close();
            }

            return categorias.Where(c => c.Codigo == codigo).FirstOrDefault();
        }

        public void Excluir(int codigo)
        {
            var categoriaAExcluir = Obter(codigo);
            this.categorias.Remove(categoriaAExcluir);
        }
    }
}
