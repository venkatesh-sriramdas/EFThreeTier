using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface iDepartmentRepository
    {
        List<DepartmentModel> GetDepartmanets();

        List<EmployeesModel> GetEmployeesBasedOnDepartment(int intDepartmentID);
    }
}
