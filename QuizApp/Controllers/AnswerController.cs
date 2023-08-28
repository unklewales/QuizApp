using Microsoft.AspNetCore.Mvc;

namespace QuizApp.Controllers
{
    public class AnswerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
