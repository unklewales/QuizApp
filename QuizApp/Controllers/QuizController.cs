using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuizApp.Models;
using QuizApp.Repository.IRepository;
using QuizApp.ViewModels;

namespace QuizApp.Controllers
{
    public class QuizController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuizController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Quiz> quizList = _unitOfWork.Quiz.GetAll(includeProperties: "Department").ToList();
            return View(quizList);
        }

        public IActionResult CreateQuiz()
        {
            QuizView vm = new()
            {
                DepartmentList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
                {
                    Text = u.DepartmentalName,
                    Value = u.DepartmentId.ToString()
                 }),

                Quiz = new Quiz()
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult CreateQuiz(QuizView obj)
        {

            if (ModelState.IsValid)
            {

                _unitOfWork.Quiz.AddAObj(obj.Quiz);
                Console.WriteLine(obj.Quiz);
                _unitOfWork.Save();
                return RedirectToAction("Index");


            }

            return View(obj);
        }
    }
}

