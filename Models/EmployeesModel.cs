using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EmployeesModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        //below prop is not having column in db
      //  public string FullName { get; set; }

        public string Gender { get; set; }
        public int? Salary { get; set; }
        public int? DepartmentId { get; set; }

    }
}

