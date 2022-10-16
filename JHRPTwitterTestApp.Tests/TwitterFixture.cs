using JHRPTwitterTestApp.Data.TwitterApi.ApiAccess;
using JHRPTwitterTestApp.Data.TwitterApi.Client;
using JHRPTwitterTestApp.Web.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JHRPTwitterTestApp.Tests
{
    public class TwitterFixture
    {
        public TwitterFixture()
        {
            var serviceCollection = new ServiceCollection();

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.test.json")
                .AddEnvironmentVariables()
                .Build();


            serviceCollection.AddTransient((provider) =>
            {
                return new TwitterRestClient(config["TwitterApiEndpoint/Url"], config["TwitterApiEndpoint/BearerToken"], null);
            });
            serviceCollection.AddTransient<TwitterApiAccess>();
            serviceCollection.AddTransient<TwitterService>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
        public ServiceProvider ServiceProvider { get; private set; }
    }
}
