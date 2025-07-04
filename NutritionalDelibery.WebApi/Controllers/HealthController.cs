using Microsoft.AspNetCore.Mvc;

namespace NutritionalDelibery.WebApi.Controllers
{
    [ApiController]
    [Route("health")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHealth()
        {
            return Ok(new { status = "ok" });
        }
    }
}
