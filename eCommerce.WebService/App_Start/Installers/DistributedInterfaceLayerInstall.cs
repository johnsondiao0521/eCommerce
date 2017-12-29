using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using eCommerce.Helpers.Logging;
using eCommerce.WebService.App_Start;

namespace eCommerce.WebService
{
    public class DistributedInterfaceLayerInstall : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
   .BasedOn<IHttpController>()
   .Configure(c => c.LifestyleTransient()));

            container.Register(Component.For<IRequestCorrelationIdentifier>().ImplementedBy<W3CWebRequestCorrelationIdentifier>().LifeStyle.PerWebRequest);
        }
    }
}