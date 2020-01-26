using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

namespace EFThreeTier.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        iDepartmentRepository _iDepartmentRepository;

        public DepartmentController(iDepartmentRepository IDepartmentRepository)
        {
            _iDepartmentRepository = IDepartmentRepository; 
        }
        public ActionResult Index()
        {
            List<DepartmentModel> departments = _iDepartmentRepository.GetDepartmanets();
            return View(departments);
        }
        
        public ActionResult GetEmployeesBasedOnDepartment(int _DepartmentID)
        {
            List<EmployeesModel> employees = _iDepartmentRepository.GetEmployeesBasedOnDepartment(_DepartmentID);
            return View(employees);
        }
    }
}