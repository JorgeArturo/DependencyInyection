using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;

namespace DependencyInyectionTest
{
    //https://youtu.be/mCUNrRtVVWY?t=898
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterType<DataAccess>().As<IDataAccess>();
            //builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BetterBusinessLogic>().As<IApplication>();
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DependencyInyectionTest)))
            .Where(t=> t.Namespace.Contains("Utilities"))
            .As(t => t.GetInterfaces().FirstOrDefault(i=>i.Name=="I"+ t.Name));

            return builder.Build();
        }
    }
}