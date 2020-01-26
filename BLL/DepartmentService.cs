using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class DepartmentService : iDepartmentRepository
    {
        private sampleEntitiesConnectionString _sampleDB;
        public DepartmentService(sampleEntitiesConnectionString objsampleEntitiesConnectionString)
        {
            _sampleDB = objsampleEntitiesConnectionString;
        }
        public List<DepartmentModel> GetDepartmanets()
        {
            try
            {
                List<DepartmentModel> departments = (from dept in _sampleDB.Departments

                                                       select new DepartmentModel{
                                                       ID = dept.ID,
                                                       Location = dept.Location,
                                                       Name = dept.Name
                                                        }
                                                  ).ToList<DepartmentModel>();

                return departments;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<EmployeesModel> GetEmployeesBasedOnDepartment(int intDepartmentID)
        {
            try
            {
                List<EmployeesModel> departments = (from emps in _sampleDB.Employees
                                    where emps.DepartmentId == intDepartmentID
                                                     
                                    select new EmployeesModel
                                    {
                                        ID = emps.ID,
                                        DepartmentId= emps.DepartmentId,
                                        FirstName= emps.FirstName,
                                         LastName= emps.LastName,
                                         Gender= emps.Gender,
                                         Salary = emps.Salary
                                    }
                                  ).ToList<EmployeesModel>();

                return departments;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

