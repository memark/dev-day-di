using System;
using System.Reflection;
using Autofac;

namespace ConsoleAppAutofac
{
	class Program
	{
		static void Main(string[] args)
		{
			var container = CreateContainer();

			using (var scope = container.BeginLifetimeScope())
			{
				var app = scope.Resolve<ConsoleApp>();
            
				app.Run();
			}
		}
        
        private static IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<ConsoleApp>().AsSelf();
            containerBuilder.RegisterType<DependencyA>().AsSelf();
            containerBuilder.RegisterType<DependencyB>().AsImplementedInterfaces();
              
			return containerBuilder.Build();
		}

        private static IContainer CreateContainerByConvention()
        {
            var containerBuilder = new ContainerBuilder();
         
            var thisAssembly = Assembly.GetExecutingAssembly();
            containerBuilder.RegisterAssemblyTypes(thisAssembly)
			                .Where(x => x.Name.EndsWith("Service"))
			                .AsSelf().AsImplementedInterfaces();

            return containerBuilder.Build();
        }
	}
}
