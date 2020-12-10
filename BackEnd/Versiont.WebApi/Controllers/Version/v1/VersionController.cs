using Microsoft.AspNetCore.Mvc;

namespace Versiont.WebApi.Controllers.Version.v1
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("1.0")]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var jsonResult = new {Name = "Helena", Message = "Hello"};

            return Ok(jsonResult);
        }
    }
}