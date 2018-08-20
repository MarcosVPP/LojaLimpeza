using NHibernate;
using NHibernate.Cfg;
using System.Collections.Generic;
using System.Linq;

namespace LojaLimpeza.DAL
{
    public class CategoriaDAO
    {
        private Configuration myConfiguration;
        private ISessionFactory sessionFactory;
        private ISession mySession;

        private List<Domain.CategoriaDomain> categorias;

        public CategoriaDAO()
        {
            this.categorias = new List<Domain.CategoriaDomain>();
            /*    categorias.Add(new Domain.Categoria(1, "Cozinha"));
                  categorias.Add(new Domain.Categoria(2, "Vidros"));
                  categorias.Add(new Domain.Categoria(3, "Banheiro"));
            */
        }
     


            public void Salvar(Domain.CategoriaDomain categoria)
        {
            var categoriaSalva = Obter(categoria.Codigo);

            if (categoriaSalva == null)
            {
                this.categorias.Add(categoria);

                Configuration configuration = new Configuration();
                configuration.Configure();
                configuration.AddAssembly(typeof(Mappings).Assembly);

            }

            else
            {
                categoriaSalva.Nome = categoria.Nome;
            }
        }

        public List<Domain.CategoriaDomain> Listar()
        {
            return categorias;
        }

        public Domain.CategoriaDomain Obter(int codigo)
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
