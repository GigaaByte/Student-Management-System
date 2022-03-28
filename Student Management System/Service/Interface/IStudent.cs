using Student_Management_System.Models;
using System.Collections.Generic;

namespace Student_Management_System.Intefrace
{
    public interface IStudent
    {

        public List<Student> GetDetails();
        public List<Student> StudentDetails();

    }
}
