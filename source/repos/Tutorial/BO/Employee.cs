using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ID_Number { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int DepartmentID { get; set; }
        public int ManagerID { get; set; }
    }
}
