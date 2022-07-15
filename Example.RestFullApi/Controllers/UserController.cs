using Example.BussinesLayer.Absraction;
using Microsoft.AspNetCore.Mvc;

namespace Example.RestFullApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserManager<Entites.concrete.User, Core.Concrete.Result<object>> userManager;
        public UserController(IUserManager<Entites.concrete.User, Core.Concrete.Result<object>>  userManager)
        {
                this.userManager = userManager;
        }
        [HttpPost("CreateUser")]
        public ActionResult<Core.Bussines.IResult<object>> CreateUser([FromBody] Entites.concrete.User user)
        {
            return userManager.CreateUser(user);
        }

        [HttpPost("Login")]
        public ActionResult<Core.Bussines.IResult<object>> Login(string Username,string Password)
        {
            return userManager.SignIn(Username,Password);
        }
    }
}
