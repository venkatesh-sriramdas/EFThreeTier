using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace EFThreeTier.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        iDepartmentRepository _iDepartmentRepository;

        DepartmentService departmentService;

        public DepartmentController(iDepartmentRepository IDepartmentRepository)
        {
            _iDepartmentRepository = IDepartmentRepository; 
            departmentService = new DepartmentService();
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