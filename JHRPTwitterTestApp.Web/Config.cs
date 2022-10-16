using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JHRPTwitterTestApp.Web
{
    public class Config
    {
        public class TwitterApiEndpoint
        {
            public  string Url { get; set; }
            public  string BearerToken { get; set; }
        }
    }
}
