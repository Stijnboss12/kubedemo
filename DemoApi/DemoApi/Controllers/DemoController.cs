using Microsoft.AspNetCore.Mvc;
using System;

namespace DemoApi.Controllers
{
    [ApiController]
    [Route("demo")]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            return "Hello World";
        }
    }
}