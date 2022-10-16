using JHRPTwitterTestApp.Data.TwitterApi.ApiAccess;
using JHRPTwitterTestApp.Data.TwitterApi.Client;
using JHRPTwitterTestApp.Web;
using JHRPTwitterTestApp.Web.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace JHRPTwitterTestApp
{
    public class Startup : ServiceStartupBase
    {
        public Startup(IWebHostEnvironment env)
            : base(env, 8080, "/")
        {
        }

        protected override void ConfigureApplicationServices(IServiceCollection services)
        {
            var twitterConfig = Configuration.GetSection("TwitterApiEndpoint").Get<Config.TwitterApiEndpoint>();

            services.AddTransient((provider) =>
            {
                var ilogger = provider.GetRequiredService<ILogger<TwitterRestClient>>();
                return new TwitterRestClient(twitterConfig.Url, twitterConfig.BearerToken, ilogger);
            });

            services.AddTransient<TwitterApiAccess>();
            services.AddTransient<TwitterService>();
        }
        protected override void ConfigureApplication(IApplicationBuilder app, IWebHostEnvironment env)
        {
        }
    }
}
