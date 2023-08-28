using Microsoft.AspNetCore.Mvc;

namespace QuizApp.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
