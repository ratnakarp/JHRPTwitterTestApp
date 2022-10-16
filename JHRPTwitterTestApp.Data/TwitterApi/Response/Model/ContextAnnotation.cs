using JHRPTwitterTestApp.Data.TwitterApi.Response.Abstractions;

namespace JHRPTwitterTestApp.Data.TwitterApi.Response.Model
{
    public class ContextAnnotation : IContextAnnotation
    {
        public IDomain domain { get; set; }
        public IEntity entity { get; set; }
    }
}
