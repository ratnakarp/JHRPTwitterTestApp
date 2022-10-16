using JHRPTwitterTestApp.Data.TwitterApi.Response;
using System.Threading.Tasks;

namespace JHRPTwitterTestApp.Data.TwitterApi.Abstractions
{
    public interface ITwitterApiAccess
    {
        public Task<SampleStreamModel> GetSampleStreamAsync();
    }
}
