using Microsoft.AspNetCore.Mvc;

namespace webapi_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        public Movie Get()
        {
            return new Movie{Title = "x", LeadActor = "y"};
        }
    }
}