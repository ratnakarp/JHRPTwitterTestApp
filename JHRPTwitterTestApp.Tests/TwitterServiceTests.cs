using JHRPTwitterTestApp.Web.Service;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace JHRPTwitterTestApp.Tests
{
    public class TwitterServiceTests : IClassFixture<TwitterFixture>
    {
        private readonly ServiceProvider _serviceProvider;
        public TwitterServiceTests(TwitterFixture fixture)
        {
            _serviceProvider = fixture.ServiceProvider;
        }

        [Fact]
        public void GetSampleStreamAsync_ReturnsRecord()
        {
            var _twitterService = _serviceProvider.GetService<TwitterService>();
            Assert.NotNull(_twitterService.GetSampleStreamAsync());
        }
    }
}
