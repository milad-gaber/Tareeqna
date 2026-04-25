using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tareeqna.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsermanagementController : ControllerBase
    {
        [HttpGet("HiFromUsermanagement")]
        public string SayHi()
        {
            return "Hi shady";
        }
    }







}

//api/Usermanagement/HiFromUsermanagement
