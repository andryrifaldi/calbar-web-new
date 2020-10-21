using System.Web.Mvc;
using Bootstrapper;
using Core.Data;
using Core.Services;
using Data;
using Services;
using Autofac;
using Autofac.Integration.Mvc;
using Web;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(IocConfig), "RegisterDependencies")]

namespace Bootstrapper
{
    public class IocConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            const string nameOrConnectionString = "name=default";
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterGeneric(typeof(EntityRepository<>)).As(typeof(IRepository<>)).InstancePerHttpRequest();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerHttpRequest();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerHttpRequest();
            builder.Register<IEntitiesContext>(b =>
            {
                var context = new ApplicationDbContext(nameOrConnectionString);
                return context;
            }).InstancePerHttpRequest();
            builder.RegisterModule(new IdentityModule());

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
