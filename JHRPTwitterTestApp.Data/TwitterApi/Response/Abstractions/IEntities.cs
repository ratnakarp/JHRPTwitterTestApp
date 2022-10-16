using System.Collections.Generic;

namespace JHRPTwitterTestApp.Data.TwitterApi.Response.Abstractions
{

    public interface IEntities
    {
        public List<IUrl> urls { get; set; }
        public List<IAnnotation> annotations { get; set; }
    }
}
