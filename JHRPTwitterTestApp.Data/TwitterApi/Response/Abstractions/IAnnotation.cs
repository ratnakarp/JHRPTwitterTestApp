namespace JWRPTwitterTestApp.Data.TwitterApi.Response.Abstractions
{
    public interface IAnnotation 
    {
        public int start { get; set; }
        public int end { get; set; }
        public double probability { get; set; }
        public string type { get; set; }
        public string normalized_text { get; set; }
    }
}
