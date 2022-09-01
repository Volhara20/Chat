using Chat.Data;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        public UserController(ApplicationContext applicationContext)
        {
        }

        [HttpGet]
        public void Get()
        {

        }
    }
}