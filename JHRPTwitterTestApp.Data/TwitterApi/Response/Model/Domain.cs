using JHRPTwitterTestApp.Data.TwitterApi.Response.Abstractions;

namespace JHRPTwitterTestApp.Data.TwitterApi.Response.Model
{
    public class Domain : IDomain
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
