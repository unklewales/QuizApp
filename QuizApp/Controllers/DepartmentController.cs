using Microsoft.AspNetCore.Mvc;
using QuizApp.Data;
using QuizApp.Models;
using QuizApp.Repository.IRepository;
using QuizApp.ViewModels;

namespace QuizApp.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;   
        }
        public IActionResult Index()
        {
            List<Department> departmentList =  _unitOfWork.Department.GetAll().ToList();
            return View(departmentList);
        }

        public IActionResult CreateDept()
        {
            DepartmentView vm = new()
            {
                Department = new Department()
            };
            
            return View(vm);
        }

        [HttpPost]
        public IActionResult CreateDept(DepartmentView obj) 
        {

            if (ModelState.IsValid)
            {
               
                    _unitOfWork.Department.AddAObj(obj.Department);
                    _unitOfWork.Save();
                    return RedirectToAction("Index");

               
            }

            return View();
        }
    }
}
