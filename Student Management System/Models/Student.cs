using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Student_Management_System.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public int DepartmentId { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public enum Gender
        {

            Male = 1,
            Female,
            Others

        }

    }
}
