using Microsoft.AspNetCore.Mvc;

namespace App.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class AppController : ControllerBase {
        [HttpGet]
        public IActionResult Get() {
            return Ok("Hello World 1");
        }

        [HttpPost]
        public IActionResult Post() {
            return Ok("Hello World");
        }
    }
}