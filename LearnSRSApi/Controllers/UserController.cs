using LearnSRSApi.Data;
using LearnSRSApi.Models;
using LearnSRSApi.System;
using LearnSRSApi.System.Users;
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

        [HttpGet("getAll")]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _userService.GetAllUser();
            return Ok(users);
        }
        [HttpPost("register")]
        public IActionResult Register(UserRegister request)
        {
            _userService.AddUser(request);
            return Ok(new { message = "User created" });
        }
    }
}
