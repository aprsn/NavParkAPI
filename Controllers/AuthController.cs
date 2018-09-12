using Microsoft.AspNetCore.Mvc;

namespace NavPark_API.Controllers
{
     [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAuth(){
            

            return StatusCode(201);
        }

    }
}