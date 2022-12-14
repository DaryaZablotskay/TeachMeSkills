using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lesson15
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddOpenApiDocument(config=>
            {
                config.Title = "My best site";
            });
            services.AddScoped<IHomeServises, HomeServises>();
            services.AddSingleton<IHomeServises, HomeServises>();
            services.AddTransient<IHomeServises, HomeServises>();
            //services.AddScoped<IA, A>();
            //services.AddScoped<IB, B>();
            //services.AddScoped<IC, C>();

            services.Configure<ComplexSettings>(Configuration.GetSection(ComplexSettings.path));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseOpenApi(); // serve OpenAPI/Swagger documents
            app.UseSwaggerUi3(config=>
            {
                config.DocumentTitle = "My web site";
                config.DocExpansion = "list";
            }
                ); // serve Swagger UI

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
