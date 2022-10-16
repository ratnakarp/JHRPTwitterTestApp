using JHRPTwitterTestApp.Data.TwitterApi.Client;
using JHRPTwitterTestApp.Data.TwitterApi.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JHRPTwitterTestApp.Data.TwitterApi.ApiAccess
{
    public class TwitterApiAccess
    {
        private readonly TwitterRestClient _twitterRestClient;
        private const string SAMPLE_STREAM_API_ENDPOINT = "tweets/sample/stream";
        public TwitterApiAccess(TwitterRestClient twitterRestClient)
        {
            _twitterRestClient = twitterRestClient;
        }

        public async Task<List<SampledStreamResponse>> GetSampleStreamAsync()
        {
            var response = await _twitterRestClient.GetAsync(SAMPLE_STREAM_API_ENDPOINT);
            return response;
        }
    }
}
