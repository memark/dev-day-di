using Microsoft.Extensions.DependencyInjection;

namespace ConsoleAppMSDI
{
	class Program
	{
		static void Main(string[] args)
		{
			var serviceProvider = CreateServiceProvider();

			using (var scope = serviceProvider.CreateScope())
			{
				var app = scope.ServiceProvider.GetRequiredService<ConsoleApp>();
				app.Run();
			}
		}

		private static ServiceProvider CreateServiceProvider()
		{
			var services = new ServiceCollection();

			services.AddTransient<ConsoleApp>();
			services.AddTransient<DependencyA>();
			services.AddTransient<IDependencyB, DependencyB>();

			return services.BuildServiceProvider();
		}
	}
}
