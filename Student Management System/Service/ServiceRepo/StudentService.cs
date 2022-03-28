using Student_Management_System.Intefrace;
using Student_Management_System.Models;
using System.Collections.Generic;

namespace Student_Management_System.Views.Service
{
    public class StudentService : IStudent
    {
        public List<Student> GetDetails()
        {

            return StudentDetails();
        }

        public List<Student> StudentDetails()
        {

            List<Student> studentlist = new List<Student>()
            {

                new Student()
                {
                    DepartmentId =  101,
                    FirstName = "Akash",
                    LastName =  "Dhar",
                    Email = "akash@123.com",
                    DOB = new System.DateTime(1998,11,06)
                },
                   new Student()
                {
                    DepartmentId =  102,
                    FirstName = "Shubam",
                    LastName =  "Rana",
                    Email = "shubam@123.com",
                    DOB = new System.DateTime(1994,10,16)
                }
            };

            return studentlist;
        
        }

        
    }
}