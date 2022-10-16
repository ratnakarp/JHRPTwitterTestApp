using System.Collections.Generic;

namespace JHRPTwitterTestApp.Data.TwitterApi.Response
{
    public class SampleStreamModel
    {
        public int TotalCount { get; set; }
        public List<SampledStreamResponse> ListOfSampledStreamResponse { get; set; }
    }
}
