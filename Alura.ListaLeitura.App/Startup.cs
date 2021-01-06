using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.ListaLeitura.App
{
    internal class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {            
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            // use somente em desenvolvimento
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();
        }
    }
}