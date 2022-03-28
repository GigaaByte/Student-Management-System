using Student_Management_System.Intefrace;
using Student_Management_System.Models;
using System.Collections.Generic;

namespace Student_Management_System.Views.Service
{
    public class StaffService : IStaff
    {
        public List<Staff> GetDetails()
        {
            return StaffDetails();
        }
        public List<Staff> StaffDetails()
        {

            List<Staff> stafflist = new List<Staff>()
            {

                new Staff()
                {   StaffId = 1,
                    DepartmentId =  101,
                    FirstName = "Akash",
                    LastName =  "Dhar",
                    Email = "Akash@gmail.com",

                },
                   new Staff()
                {
                    StaffId = 2,
                    DepartmentId =  102,
                    FirstName = "Shubam",
                    LastName =  "Rana",
                    Email = "Shubamrana@gmail.com",

                }
            };

            return stafflist;

        }

    }
}