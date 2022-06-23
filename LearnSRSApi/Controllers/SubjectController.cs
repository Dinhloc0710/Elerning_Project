using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LearnSRSApi.Models;

namespace LearnSRSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService  _isubjectService;
        public SubjectController(ISubjectService isubjectService)
        {
            _isubjectService = isubjectService;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var s = _isubjectService.getAll();
            if (s == null)
            {
                return NotFound();
            }
            return Ok(s);
        }
        [HttpGet("{SubjectId}")]
        public ActionResult GetPower(int SubjectId)
        {
            var s = _isubjectService.Get(SubjectId);
            if (s == null)
            {
                return NotFound();
            }
            return Ok(s);
        }
        [HttpPost]
        public ActionResult PostPower(Subject s)
        {
            _isubjectService.Create(s);
            return Ok();

        }
        [HttpDelete("{SubjectId}")]
        public ActionResult Delete(int SubjectId)
        {
            _isubjectService.Delete(SubjectId);
            return NoContent();
        }
        [HttpPut]
        public ActionResult PutPower(Subject s)
        {
            _isubjectService.Update(s);
            return NoContent();
        }
    }
}
