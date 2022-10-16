using JHRPTwitterTestApp.Data.TwitterApi.Response.Abstractions;

namespace JHRPTwitterTestApp.Data.TwitterApi.Response.Model
{
    public class Entity : IEntity
    {
        public object id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
