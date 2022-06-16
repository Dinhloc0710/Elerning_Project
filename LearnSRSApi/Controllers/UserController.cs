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
        private readonly IUserService _iuserService;
        public UserController(IUserService iuserService, DataContext context)
        {
            _context = context;
            _iuserService = iuserService;
        }
        [HttpGet("GetAllUser")]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _iuserService.GetAllUser();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public ActionResult GetUser(int id)
        {
            var user = _iuserService.get(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPost]
        public ActionResult PostUser(User user)
        {
            return Ok();

        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return NoContent();
        }

    }
}
