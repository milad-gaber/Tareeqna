using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tareeqna.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("name1")]
        public string SayHiShady()
        {
            return "Hi Shady .";
        }


        [HttpPost("name2")]
        public string SayHiAbanob()
        {
            return "Hi Abanob .";
        }


        [HttpGet("name2")]
        public string SayHiAbanobaa()
        {
            return "Hi Abanob From Get method.";
        }


        string goodMessage = "Welcome! ^_^";
        string badMessage = "Sorry! You Are not Authrized to login !";

        [HttpPost("Auth")]
        public string Login1([FromBody] LoginRequest request)
        {

            if (request.Username == "shadywaheed" && request.Password == "123")
            {
                return goodMessage;
            }
            else 
            {
                return badMessage;
            }
        }




        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest dto)
        {
            string correctEmail = "Shadywaheed078@gmail.com";
            string correctPassword = "123";

            if (dto.Username.Equals(correctEmail, StringComparison.OrdinalIgnoreCase)
                && dto.Password == correctPassword)
            {
                return Ok(new
                {
                    status = true,
                    message = "Welcome"
                });
            }

            return BadRequest(new
            {
                status = false,
                message = "Invalid email or password"
            });
        }
    }
}

