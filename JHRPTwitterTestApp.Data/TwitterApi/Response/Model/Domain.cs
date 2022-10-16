using JWRPTwitterTestApp.Data.TwitterApi.Response.Abstractions;

namespace JWRPTwitterTestApp.Data.TwitterApi.Response.Model
{
    public class Domain : IDomain
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
