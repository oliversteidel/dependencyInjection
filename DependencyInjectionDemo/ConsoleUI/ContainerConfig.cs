using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            // store definitions of all classes to instanciate
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BetterBusinessLogic>().As<IBusinessLogic>();

            // in DemoLibrary look for namespaces which contains "Utilities" and register all Interfaces
            // all Interfaces start with "I" (i.Name == "I")
            // same like (builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();) but for every file in "Utilities" folder
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            // builds the container
            return builder.Build();
        }
    }
}
