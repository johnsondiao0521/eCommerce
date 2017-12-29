using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace eCommerce.WebService
{
    public class ApplicationLayerInstall : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssembly(typeof(eCommerce.ApplicationLayer.Customers.ICustomerService).Assembly)
               .Where(x => !x.IsInterface && !x.IsAbstract && !x.Name.EndsWith("Dto") && x.Namespace.Contains("ApplicationLayer"))
               .WithService.DefaultInterfaces()
               .Configure(c => c.LifestyleTransient()));
        }
    }
}