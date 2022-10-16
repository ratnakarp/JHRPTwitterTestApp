using JWRPTwitterTestApp.Data.TwitterApi.Response.Abstractions;

namespace JWRPTwitterTestApp.Data.TwitterApi.Response.Model
{
    public class ReferencedTweet : IReferencedTweet
    {
        public string type { get; set; }
        public string id { get; set; }
    }
}
