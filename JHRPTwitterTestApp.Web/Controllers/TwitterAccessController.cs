using JHRPTwitterTestApp.Web.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JHRPTwitterTestApp.Web.Controllers
{
    [Route("api/TwitterAccess/[action]")]
    [ApiController]
    public class TwitterAccessController : ControllerBase
    {
        private TwitterService _twitterManager;
        public TwitterAccessController(TwitterService twitterManager)
        {
            _twitterManager = twitterManager;
        }

        [HttpGet]
        [ActionName("GetSampleStream")]
        public async Task<IActionResult> GetSampleStreamAsync()
        {
            var result = await _twitterManager.GetSampleStreamAsync();
            return new JsonResult(result);
        }
    }
}
