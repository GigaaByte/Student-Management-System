using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Student_Management_System.Intefrace;
using Student_Management_System.Models;
using System.Collections.Generic;


namespace Student_Management_System.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly IDepartment _Department;

        public DepartmentController(IDepartment Department)
        {
            _Department = Department;
        }

        //public IActionResult Index() 
        //{
        //    int a = 3 , b = 0;
        //    var c = a / b;

        //    Department department = new();
        //    department.DepartmentId = _Department.GetDetails();
        //    ViewData["name"] = department.DepartmentName;
        //    return View(department);

        //    return View();
        //}

        public IActionResult AddEdit()
        {
            int a = 3, b = 0;
            var c = a / b;

            return View();
        }
        [HttpPost]
        public IActionResult AddEdit(Models.Department d)
        {

            return View(d);
        }

        public IActionResult Contact()
        {
            List<Models.Department> d = _Department.GetDetails();

            HttpContext.Session.SetObjectAsJson("DepartmentId", d);

            ViewData["Department"] = HttpContext.Session.GetObjectFromJson<List<Models.Department>>("DepartmentId");

            return View();
        }

        public IActionResult AboutUs()
        {

            return View();
        }

    }
}
