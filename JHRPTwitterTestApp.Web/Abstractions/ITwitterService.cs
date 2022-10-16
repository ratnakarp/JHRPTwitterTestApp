using JHRPTwitterTestApp.Data.TwitterApi.Response;
using System.Threading.Tasks;

namespace JHRPTwitterTestApp.Web.Abstractions
{
    public interface ITwitterService
    {
        public Task<SampleStreamModel> GetSampleStreamAsync();
    }
}
