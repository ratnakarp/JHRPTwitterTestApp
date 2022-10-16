using JHRPTwitterTestApp.Data.TwitterApi.Response.Abstractions;

namespace JHRPTwitterTestApp.Data.TwitterApi.Response.Model
{
    public class Url : IUrl
    {
        public int start { get; set; }
        public int end { get; set; }
        public string url { get; set; }
        public string expanded_url { get; set; }
        public string display_url { get; set; }
        public int status { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}
