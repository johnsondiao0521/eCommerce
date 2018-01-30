﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace eCommerce.PassThroughEventBus.Test
{
    public class Program
    {
        public Program()
        {

        }
        static void Main(string[] args)
        {
            try
            {
                var builder = new ContainerBuilder();
                builder.RegisterType<CustomerCreatedEventHandler>().As<IEventHandler>();
                builder.RegisterType<PassThroughEventBus>().As<IEventBus>();
                using (var container = builder.Build())
                {
                    var eventBus = container.Resolve<IEventBus>();
                    eventBus.PublishAsync(new CustomerCreatedEvent("johnson"));
                }
            }
            catch (Exception ex)
            {
            }

            Console.ReadKey();
        }

    }
}
