using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace WebAppAutofac
{
	public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

		public void ConfigureContainer(ContainerBuilder builder)
        {
			builder.RegisterType<DependencyA>().AsSelf();
			builder.RegisterType<DependencyB>().AsImplementedInterfaces();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();

            app.UseMvc();
        }
    }
}
