using LearnSRSApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnSRSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IClassService _iclassService;
        public ClassController(IClassService iclassService)
        {
            _iclassService = iclassService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var cl = _iclassService.getAll();
            if (cl == null)
            {
                return NotFound();
            }
            return Ok(cl);
        }
        [HttpGet("{id}")]
        public ActionResult GetClass(int id)
        {
            var cl = _iclassService.Get(id);
            if (cl == null)
            {
                return NotFound();
            }
            return Ok(cl);
        }
    }
}
