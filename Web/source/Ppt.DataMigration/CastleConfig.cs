using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using System.Collections;

namespace Ppt.DataMigration
{
    public static class CastleConfig
    {
        static IWindsorContainer _container;


        static CastleConfig()
        {
            _container = new WindsorContainer();

            _container.AddFacility(new global::Castle.Facilities.Logging.LoggingFacility(Castle.Facilities.Logging.LoggerImplementation.NLog));

            _container.Register(
                AllTypes.FromAssemblyContaining<Mvp.IPresenter>()
                .BasedOn<Mvp.IPresenter>().WithService.Self().Configure(c=> c.LifestyleTransient())
                );
            
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
        public static T Resolve<T>(IDictionary<string, object> args)
        {
            return _container.Resolve<T>(args as IDictionary);
        }
    }
}
