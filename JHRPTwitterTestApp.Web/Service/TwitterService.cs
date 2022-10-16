using JHRPTwitterTestApp.Data.TwitterApi.ApiAccess;
using JHRPTwitterTestApp.Data.TwitterApi.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JHRPTwitterTestApp.Web.Service
{
    public class TwitterService
    {
        private readonly TwitterApiAccess _twitterApiAccess;
        public TwitterService(TwitterApiAccess twitterApiAccess)
        {
            _twitterApiAccess = twitterApiAccess;
        }

        public async Task<List<SampledStreamResponse>> GetSampleStreamAsync()
        {
            return await _twitterApiAccess.GetSampleStreamAsync();
        }
    }
}
