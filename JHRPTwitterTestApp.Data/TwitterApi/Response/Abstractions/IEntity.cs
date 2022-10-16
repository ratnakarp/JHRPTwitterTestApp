namespace JHRPTwitterTestApp.Data.TwitterApi.Response.Abstractions
{
    public interface IEntity
    {
        public object id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
