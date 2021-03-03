using Automation.Business.Abstract;
using Automation.Entities.Concrete;
using AutomationUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomationUI.Controllers
{
    public class EmployeesController : Controller
    {
        IEmployeeManager _employeeManager;

        public EmployeesController(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new EmployeeListViewModel
            {
                Employees = _employeeManager.GetAll()
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            var departmentList = new DepartmentListViewModel().GetDepartmentsListItems();
            ViewBag.departmentList = departmentList;
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            _employeeManager.Add(employee);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteEmployee(int id)
        {
            var employee = _employeeManager.GetById(id);
            employee.IsActive = !employee.IsActive;
            _employeeManager.Update(employee);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateEmployee(int id)
        {
            var departmentList = new DepartmentListViewModel().GetDepartmentsListItems();
            ViewBag.departmentList = departmentList;
            var employee = _employeeManager.GetById(id);
            return View("UpdateEmployee", employee);
        }
        [HttpPost]
        public ActionResult UpdateEmployee(Employee employee)
        {
            _employeeManager.Update(employee);
            return RedirectToAction("Index");
        }
    }
}