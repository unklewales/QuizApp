using Microsoft.AspNetCore.Mvc;
using QuizApp.Models;
using QuizApp.Repository.IRepository;
using QuizApp.ViewModels;

namespace QuizApp.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuestionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateQuestion(int quizId) 
        {
            QuestionView vm = new()
            {
                Question = new Question
                {
                    Quiz = new Quiz
                    {
                        QuizId = quizId
                    }
                }
                
            };

            

            return View(vm);  
        }

        [HttpPost]
        public IActionResult CreateQuestion(QuestionView obj)
        {


            if (ModelState.IsValid)
            {
                
                _unitOfWork.Question.AddAObj(obj.Question);
                
                _unitOfWork.Save();
                return RedirectToAction("Index");
                
            }

            return View(obj);
        }
    }
}
