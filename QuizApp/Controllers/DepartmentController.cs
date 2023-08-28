using Microsoft.AspNetCore.Mvc;

namespace QuizApp.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
