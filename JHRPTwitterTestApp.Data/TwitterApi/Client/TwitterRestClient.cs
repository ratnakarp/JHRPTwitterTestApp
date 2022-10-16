using JHRPTwitterTestApp.Data.TwitterApi.Response;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace JHRPTwitterTestApp.Data.TwitterApi.Client
{
    public class TwitterRestClient
    {
        private readonly string _apiUrl;
        private readonly string _bearerToken;
        private WebRequest _request;
        private int _maxCount = 10;
        private readonly ILogger<TwitterRestClient> _twitterRestCLogger;
        private readonly IMemoryCache _memoryCache;
        private readonly string CacheKey = "SampleStreamList";
        public TwitterRestClient(string apiUrl, string bearerToken, ILogger<TwitterRestClient> twitterRestCLogger, IMemoryCache memoryCache)
        {
            _apiUrl = apiUrl;
            _bearerToken = bearerToken;
            _twitterRestCLogger = twitterRestCLogger;
            _memoryCache = memoryCache;
        }


        public async Task<SampleStreamModel> GetAsync(string endPoint)
        {
            try
            {
                if (!_memoryCache.TryGetValue(CacheKey, out SampleStreamModel sampleStreamModel))
                {
                    _request = WebRequest.Create($"{_apiUrl}/{endPoint}");
                    _request.Method = "GET";

                    List<SampledStreamResponse> listOfResponses =
                        JsonConvert.DeserializeObject<List<SampledStreamResponse>>(await GetResponse(_request));

                    sampleStreamModel = new SampleStreamModel()
                    {
                        TotalCount = listOfResponses.Count,
                        ListOfSampledStreamResponse = listOfResponses?.Take(10).ToList()
                    };

                    var cacheExpiryOptions = new MemoryCacheEntryOptions
                    {
                        AbsoluteExpiration = DateTime.Now.AddSeconds(50),
                        Priority = CacheItemPriority.High,
                        SlidingExpiration = TimeSpan.FromSeconds(20)
                    };
                    //setting cache entries
                    _memoryCache.Set(CacheKey, sampleStreamModel, cacheExpiryOptions);
                }

                return sampleStreamModel;

            }
            catch (Exception e)
            {
                _twitterRestCLogger.LogError(e, e.Message);
            }

            return null;
        }

        private async Task<string> GetResponse(WebRequest request)
        {
            request.Headers.Add("Authorization", $"Bearer {_bearerToken}");
            request.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
            int tweetCount = 0;
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();

                if (response.StatusCode != HttpStatusCode.OK)
                    return null;

                Stream responseStream = response.GetResponseStream();

                if (responseStream == null)
                    return null;

                using StreamReader streamReader = new StreamReader(responseStream);
                stringBuilder.Append("[");
                while (tweetCount < _maxCount && !streamReader.EndOfStream)
                {
                    tweetCount++;
                    stringBuilder.Append(await streamReader.ReadLineAsync());
                    stringBuilder.Append(",");
                }

                stringBuilder.ToString().TrimEnd(',');
                stringBuilder.Append("]");

                return stringBuilder.ToString();
            }
            catch (Exception ex)
            {
                _twitterRestCLogger.LogError(ex.Message);
            }

            return null;
        }
    }
}
