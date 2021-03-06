﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;

namespace eCommerce.Domain
{
    public class DomainEvents
    {
        [ThreadStatic] //so that each thread has its own callbacks
        private static List<Delegate> actions;

        private static IWindsorContainer Container;
        public static void Init(IWindsorContainer container)
        {
            Container = container;
        }

        //Registers a callback for the given domain event, used for testing only
        public static void Register<T>(Action<T> callback) where T : DomainEvent
        {
            if (actions == null)
                actions = new List<Delegate>();

            actions.Add(callback);
        }

        //Clears callbacks passed to Register on the current thread
        public static void ClearCallbacks()
        {
            actions = null;
        }

        public static void Raise<T>(T @event)
            where T : DomainEvent
        {
            if (Container != null)
            {
                foreach (var handler in Container.ResolveAll<IHandles<T>>())
                {
                    handler.Handle(@event);
                }
            }

            if (actions != null)
            {
                foreach (var action in actions)
                {
                    if (action is Action<T>)
                    {
                        ((Action<T>)action)(@event);
                    }
                }
            }
        }
    }
}
