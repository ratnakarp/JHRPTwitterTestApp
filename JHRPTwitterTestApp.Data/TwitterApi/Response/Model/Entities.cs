using JHRPTwitterTestApp.Data.TwitterApi.Response.Abstractions;
using System.Collections.Generic;

namespace JHRPTwitterTestApp.Data.TwitterApi.Response.Model
{
    public class Entities : IEntities
    {
        public List<IUrl> urls { get; set; }
        public List<IAnnotation> annotations { get; set; }
    }
}
