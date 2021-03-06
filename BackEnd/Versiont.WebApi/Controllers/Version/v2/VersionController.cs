using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Versiont.WebApi.Controllers.Version.v2
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("2.0")]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var jsonResult = new
            {
                Name = "Helena",
                Message = new
                {
                    Title = "Hello",
                    SubTitle = "World"
                }
            };

            return Ok(jsonResult);
        }
    }
}