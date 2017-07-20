using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjection
{
    public class TinyUrlDependencyResolver : IDependencyResolver
    {
        protected readonly IContainer Container;

        public TinyUrlDependencyResolver(IContainer container)
        {
            if (container == null)
                throw new ArgumentNullException("container");

            Container = container;
        }


        public object GetService(Type serviceType)
        {
            if (serviceType == null)
                return null;

            return (serviceType.IsAbstract || serviceType.IsInterface)
                        ? Container.TryGetInstance(serviceType)
                        : Container.GetInstance(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Container.GetAllInstances(serviceType)
                .Cast<object>()
                .Where(s => s.GetType() == serviceType);
        }
    }
}