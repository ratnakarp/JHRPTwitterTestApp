using JWRPTwitterTestApp.Data.TwitterApi.Response.Abstractions;

namespace JWRPTwitterTestApp.Data.TwitterApi.Response.Model
{
    public class ContextAnnotation : IContextAnnotation
    {
        public IDomain domain { get; set; }
        public IEntity entity { get; set; }
    }
}
