using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp
{
	public class Startup
    {      
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

			services.AddTransient<DependencyA>();
            services.AddTransient<IDependencyB, DependencyB>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();

            app.UseMvc();
        }
    }
}
