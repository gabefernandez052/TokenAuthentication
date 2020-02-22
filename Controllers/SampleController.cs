using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TokenAuthentication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : Controller
    {
        [HttpGet]
        [Authorize]
        public IActionResult Get() => Ok(new { Response = "You are authorized" });
    }
}