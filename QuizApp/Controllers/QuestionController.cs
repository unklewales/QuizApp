using Microsoft.AspNetCore.Mvc;

namespace QuizApp.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
