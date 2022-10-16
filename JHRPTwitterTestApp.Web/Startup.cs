using JHRPTwitterTestApp.Data.TwitterApi.Abstractions;
using JHRPTwitterTestApp.Data.TwitterApi.ApiAccess;
using JHRPTwitterTestApp.Data.TwitterApi.Client;
using JHRPTwitterTestApp.Web;
using JHRPTwitterTestApp.Web.Abstractions;
using JHRPTwitterTestApp.Web.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace JHRPTwitterTestApp.Web
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

            services.AddSingleton<IMemoryCache, MemoryCache>();
            services.AddTransient((provider) =>
            {
                var iLogger = provider.GetRequiredService<ILogger<TwitterRestClient>>();
                var iMemoryCache = provider.GetRequiredService<IMemoryCache>();
                return new TwitterRestClient(twitterConfig.Url, twitterConfig.BearerToken, iLogger, iMemoryCache);
            });

            services.AddTransient<ITwitterApiAccess, TwitterApiAccess>();
            services.AddTransient<ITwitterService, TwitterService>();
        }
        protected override void ConfigureApplication(IApplicationBuilder app, IWebHostEnvironment env)
        {
        }
    }
}
