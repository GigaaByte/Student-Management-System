using Microsoft.AspNetCore.Mvc;
using Student_Management_System.Intefrace;
using Student_Management_System.Models;
using System.Collections.Generic;

namespace Student_Management_System.Controllers
{
    public class StaffController : Controller
    {

        private readonly IStaff _Staff;

        public StaffController(IStaff Staff)
        {
            _Staff = Staff;
        }

        public IActionResult AddEdit()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddEdit(Models.Staff s)
        {

            return View(s);
        }

        public IActionResult Contact()
        {

            List<Models.Staff> s = _Staff.GetDetails();


            ViewData["Staff"] = s;

            return View();
        }

        public IActionResult AboutUs()
        {

            ViewBag.Page = _Staff.GetDetails();


            return View();
        }
    }
}