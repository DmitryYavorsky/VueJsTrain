using Microsoft.AspNetCore.Mvc;

namespace TrickingLibrary.Controllers {
    [ApiController]
    [Route ("api/[controller]")]
    public class HomeController : ControllerBase {

        [HttpGet]
        public string Index () {
            return "Hi";
        }

    }
}