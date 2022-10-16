namespace JHRPTwitterTestApp.Data.TwitterApi.Response.Abstractions
{
    public interface IStats
    {
        public int retweet_count { get; set; }
        public int reply_count { get; set; }
        public int like_count { get; set; }
        public int quote_count { get; set; }
    }
}
