using LojaLimpeza.Domain;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;

namespace LojaLimpeza.DAL.Infraestrutura
{
	public class AppSessionFactory
	{
		public Configuration Configuration { get; }
		public ISessionFactory SessionFactory { get; }

		public AppSessionFactory()
		{			
			Configuration = new Configuration();
            Configuration.AddAssembly(typeof(CategoriaDomain).Assembly);
            Configuration.DataBaseIntegration(db =>
                {
                    db.ConnectionString = @"Server=.\SQLEXPRESS;initial catalog=DBLojaLimpeza;Integrated Security=true";
                    db.Dialect<MsSql2008Dialect>();
                    db.Driver<Sql2008ClientDriver>();
                });
			Configuration.SessionFactory().GenerateStatistics();

			SessionFactory = Configuration.BuildSessionFactory();
		}

		public ISession OpenSession()
		{
			return SessionFactory.OpenSession();
		}
	}
}
