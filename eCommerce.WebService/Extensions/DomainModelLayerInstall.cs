using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace eCommerce.WebService.Extensions
{
    public class DomainModelLayerInstall : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

        }
    }
}