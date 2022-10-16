using System.Collections.Generic;

namespace JWRPTwitterTestApp.Data.TwitterApi.Response.Abstractions
{

    public interface IEntities
    {
        public List<IUrl> urls { get; set; }
        public List<IAnnotation> annotations { get; set; }
    }
}
