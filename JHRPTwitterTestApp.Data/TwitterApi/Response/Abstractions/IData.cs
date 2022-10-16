using System;
using System.Collections.Generic;

namespace JWRPTwitterTestApp.Data.TwitterApi.Response.Abstractions
{
    public interface IData
    {
        public string id { get; set; }
        public DateTime created_at { get; set; }
        public string text { get; set; }
        public string author_id { get; set; }
        public string in_reply_to_user_id { get; set; }
        public List<IReferencedTweet> referenced_tweets { get; set; }
        public IEntities entities { get; set; }
        public IStats stats { get; set; }
        public bool possibly_sensitive { get; set; }
        public string lang { get; set; }
        public string source { get; set; }
        public List<IContextAnnotation> context_annotations { get; set; }
        public string format { get; set; }
    }
}
