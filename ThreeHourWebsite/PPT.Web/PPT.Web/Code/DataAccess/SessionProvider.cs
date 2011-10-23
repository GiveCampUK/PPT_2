using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions.Helpers;
using NHibernate;

namespace PPT.Web.Code.DataAccess
{
    public class SessionProvider : ISessionProvider
    {
        public static ISessionProvider Instance { get; private set; }
        public ISessionFactory SessionFactory { get; private set; }

        static SessionProvider()
        {
            Instance = new SessionProvider();
        }
        private SessionProvider()
        {
            try
            {
                SessionFactory = CreateSessionFactory();
            }
            catch (Exception ex)
            {
                Debug.Write(ex);
                throw; // we should always throw otherwise the error that gets thrown will be confusing e.g: NullReferenceException
            }
        }

        public ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public ISession OpenSession(IDbConnection connection)
        {
            return SessionFactory.OpenSession(connection);
        }

        private class FluentMappingAssembly
        {
        }

        private static ISessionFactory CreateSessionFactory()
        {
            var sessionFactory = Fluently.Configure()
              .Database(MsSqlConfiguration.MsSql2005.ConnectionString(c => c.FromConnectionStringWithKey("PPT")))
              .Mappings(m =>
                        m.FluentMappings.AddFromAssemblyOf<FluentMappingAssembly>()
                            .Conventions.Add(Table.Is(x => x.EntityType.Name))
                            .Conventions.Add(DefaultLazy.Always())
                            .Conventions.Add(DefaultAccess.Property())
                            .Conventions.Add(DefaultCascade.All())
                            .Conventions.Add(PrimaryKey.Name.Is(x => "Id")))
              .ExposeConfiguration(c =>
              {
                  if (ProfilerEnabled)
                  {
                      c.SetProperty("generate_statistics", "true");
                  }
              })
              .BuildSessionFactory();

            return sessionFactory;
        }

        public static bool ProfilerEnabled
        {
            get
            {
                bool enableProfiler;
                bool.TryParse(ConfigurationManager.AppSettings["EnableNhProfiler"], out enableProfiler);
                return enableProfiler;
            }
        }
    }

    public interface ISessionProvider
    {
        ISessionFactory SessionFactory { get; }
        ISession OpenSession();
        ISession OpenSession(IDbConnection connection);
    }
}