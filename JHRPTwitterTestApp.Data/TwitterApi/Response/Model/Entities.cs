using JWRPTwitterTestApp.Data.TwitterApi.Response.Abstractions;
using System.Collections.Generic;

namespace JWRPTwitterTestApp.Data.TwitterApi.Response.Model
{
    public class Entities : IEntities
    {
        public List<IUrl> urls { get; set; }
        public List<IAnnotation> annotations { get; set; }
    }
}
