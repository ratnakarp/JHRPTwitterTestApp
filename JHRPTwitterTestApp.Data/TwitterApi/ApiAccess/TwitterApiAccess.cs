using System.Collections.Generic;
using JWRPTwitterTestApp.Data.TwitterApi.Client;
using System.Threading.Tasks;
using JWRPTwitterTestApp.Data.TwitterApi.Response;

namespace JWRPTwitterTestApp.Data.TwitterApi.ApiAccess
{
    public class TwitterApiAccess
    {
        private TwitterRestClient _twitterRestClient;
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
