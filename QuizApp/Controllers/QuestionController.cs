using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IActionResult CreateQuestion() 
        {
            var departmentsList = _unitOfWork.Department.GetAll().Select(u => new SelectListItem
            {
                Text = u.DepartmentalName,
                Value = u.DepartmentId.ToString()
            });
            QuestionView vm = new()
            {

                DepartmentList = departmentsList,
                Question = new Question()
                
                   
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
