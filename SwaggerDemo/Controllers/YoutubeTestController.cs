using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerDemo.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class YoutubeTestController : ControllerBase
    {

        [HttpGet]
        [Route("GetYoutube")]
        public string GetYoutube()
        {
            return "Please subscribe to my youtube channel.";
        }
    }
}
