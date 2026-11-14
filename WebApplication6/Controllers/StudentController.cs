using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
