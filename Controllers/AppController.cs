using Microsoft.AspNetCore.Mvc;

namespace App.Controller {
    [ApiController]
    [Route("api/[controller]")]
    public class AppController : Controller {
        [HttpGet]
        public IActionResult Index() {
            return Ok("Hello World");
        }
    }
}