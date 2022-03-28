using Microsoft.AspNetCore.Mvc;
using Student_Management_System.Intefrace;
using Student_Management_System.Models;
using System.Collections.Generic;

namespace Student_Management_System.Controllers
{
    public class StudentController : Controller
    {

        private readonly IStudent _Student;

        public StudentController(IStudent Student)
        {
            _Student = Student;
        }

        public IActionResult AddEdit()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddEdit(Models.Student s)
        {


            return RedirectToAction("Contact");
        }

        public IActionResult Contact()
        {

            ViewData["Student"] = _Student.GetDetails();

           return View();
        }

        public IActionResult AboutUs()
        {

            return View();
        }
    }
}
