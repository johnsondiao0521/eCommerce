﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Castle.Windsor;

namespace eCommerce.WebService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private IWindsorContainer container;
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            Extensions.MappingConfig.RegisterMapping();

            container = new WindsorContainer();
            Extensions.Extensions.Register(container);
        }

        protected void Application_Stop()
        {
            if (container != null)
            {
                container.Dispose();
            }
        }
    }
}
