using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Departments
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Position { get; set; }
        public string Experience { get; set; }
        public int DepId { get; set; }
        public string Photo { get; set; }
    }
}
