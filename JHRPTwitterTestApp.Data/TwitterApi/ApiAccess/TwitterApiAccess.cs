using JHRPTwitterTestApp.Data.TwitterApi.Abstractions;
using JHRPTwitterTestApp.Data.TwitterApi.Client;
using JHRPTwitterTestApp.Data.TwitterApi.Response;
using System.Threading.Tasks;

namespace JHRPTwitterTestApp.Data.TwitterApi.ApiAccess
{
    public class TwitterApiAccess : ITwitterApiAccess
    {
        private readonly TwitterRestClient _twitterRestClient;
        private const string SampleStreamApiEndpoint = "tweets/sample/stream";
        public TwitterApiAccess(TwitterRestClient twitterRestClient)
        {
            _twitterRestClient = twitterRestClient;
        }

        public async Task<SampleStreamModel> GetSampleStreamAsync()
        {
            var response = await _twitterRestClient.GetAsync(SampleStreamApiEndpoint);
            return response;
        }
    }
}
