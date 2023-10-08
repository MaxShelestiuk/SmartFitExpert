using Microsoft.AspNetCore.Mvc;

namespace SmartFitExpert.Core.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetTest()
        {
            return Ok();
        }
    }
}
