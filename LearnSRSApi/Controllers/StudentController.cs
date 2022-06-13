using Microsoft.AspNetCore.Mvc;

namespace LearnSRSApi.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
