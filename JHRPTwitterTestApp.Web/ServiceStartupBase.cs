using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;
using NLog.Extensions.Logging;

namespace JHRPTwitterTestApp.Web
{
    public class ServiceStartupBase
    {
        public ServiceStartupBase(IWebHostEnvironment env, int port, String basePath)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            Env = env;
        }

        protected IConfigurationRoot Configuration { get; set; }
        protected IWebHostEnvironment Env { get; set; }

        protected virtual void ConfigureApplicationServices(IServiceCollection services)
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(Configuration);
            services.AddMvc(endpoint => endpoint.EnableEndpointRouting = false);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddOptions(); // Add functionality to inject IOptions<T>
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "Jack Henry Twitter Sample Coding Challenge Services",
                    Version = "v1",
                    Description = "Sample Service for Twitter Sample Stream"
                });
            });
            services.AddMemoryCache();

            ConfigureApplicationServices(services);
        }

        protected virtual void ConfigureApplication(IApplicationBuilder app, IWebHostEnvironment env)
        {
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Env = env;
            NLog.LogManager.Configuration = new NLogLoggingConfiguration(Configuration.GetSection("NLog"));

            app.UseSwagger();
            app.UseSwaggerUI(options =>
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Jack Henry Twitter Sample Coding Challenge Services"));

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            ConfigureApplication(app, env);
        }
    }
}
