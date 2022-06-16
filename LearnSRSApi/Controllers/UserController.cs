using LearnSRSApi.Data;
using LearnSRSApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnSRSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IUserService _userService;
        public UserController(IUserService userService, DataContext context)
        {
            _context = context;
            _userService = userService;
        }
        [HttpGet("GetAllUser")]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _userService.GetAllUser();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public ActionResult GetUser(int id)
        {
            var user = _userService.get(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPost]
        public ActionResult PostUser(User user)
        {
            _userService.Create(user);
            return Ok();

        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _userService.Delete(id);
            return NoContent();
        }

    }
}
