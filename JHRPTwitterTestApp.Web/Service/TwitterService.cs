using JHRPTwitterTestApp.Data.TwitterApi.Abstractions;
using JHRPTwitterTestApp.Data.TwitterApi.Response;
using JHRPTwitterTestApp.Web.Abstractions;
using System.Threading.Tasks;

namespace JHRPTwitterTestApp.Web.Service
{
    public class TwitterService : ITwitterService
    {
        private readonly ITwitterApiAccess _twitterApiAccess;
        public TwitterService(ITwitterApiAccess twitterApiAccess)
        {
            _twitterApiAccess = twitterApiAccess;
        }

        public async Task<SampleStreamModel> GetSampleStreamAsync()
        {
            return await _twitterApiAccess.GetSampleStreamAsync();
        }
    }
}
