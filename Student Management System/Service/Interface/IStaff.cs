using Student_Management_System.Models;
using System.Collections.Generic;

namespace Student_Management_System.Intefrace
{
    public interface IStaff
    {
        public List<Staff> GetDetails();
        public List<Staff> StaffDetails();
    }
}
