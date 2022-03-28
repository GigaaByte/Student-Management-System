using Student_Management_System.Intefrace;
using Student_Management_System.Models;
using System.Collections.Generic;

namespace Student_Management_System.Views.Service
{

    public class DepartmentService : IDepartment
    {

        public List<Department> GetDetails()
        {

            return DepartmentDetails();

        }

        public List<Department> DepartmentDetails()
        {

            List<Department> departmentlist = new List<Department>()
            {

                new Department()
                {
                    DepartmentId =  101,
                    DepartmentName = ".Net"

                },
                   new Department()
                {
                    DepartmentId =  102,
                    DepartmentName = "ReactJs"

                },
                   new Department()
                {
                    DepartmentId =  103,
                    DepartmentName = "Android"

                }
            };

            return departmentlist;

        }

    }

}