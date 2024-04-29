using Microsoft.AspNetCore.Mvc;

namespace App.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class AppController : ControllerBase {
        [HttpGet]
        public IActionResult Index() {
            return Ok("Hello World");
        }
    }
}