using Student_Management_System.Models;
using System.Collections.Generic;

namespace Student_Management_System.Intefrace
{
    public interface IDepartment
    {

        public List<Department> GetDetails();
        public List<Department> DepartmentDetails();

    }
}
