using Microsoft.AspNetCore.Mvc;

namespace QuizApp.Controllers
{
    public class UserQuizResultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
