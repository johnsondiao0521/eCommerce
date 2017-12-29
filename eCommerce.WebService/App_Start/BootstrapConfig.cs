
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Castle.Windsor;

namespace eCommerce.WebService
{
    public class BootstrapConfig
    {
        public static void Register(IWindsorContainer container)
        {
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator),
              new WindsorCompositionRoot(container));

            container.Install(
                 new InfrastructureLayerInstall(),
                new ApplicationLayerInstall(),
                new DomainModelLayerInstall(),
                new DistributedInterfaceLayerInstall()
                );
        }
    }
}