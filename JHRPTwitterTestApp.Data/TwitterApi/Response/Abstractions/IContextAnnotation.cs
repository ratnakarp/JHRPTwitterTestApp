namespace JWRPTwitterTestApp.Data.TwitterApi.Response.Abstractions
{
    public interface IContextAnnotation
    {
        public IDomain domain { get; set; }
        public IEntity entity { get; set; }
    }
}
