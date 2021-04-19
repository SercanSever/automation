using Automation.Business.Abstract;
using Automation.Entities.Concrete;
using AutomationUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
            var roleList = new EmployeeListViewModel().GetRoles();
            ViewBag.roleList = roleList;
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            var departmentList = new DepartmentListViewModel().GetDepartmentsListItems();
            ViewBag.departmentList = departmentList;
            var roleList = new EmployeeListViewModel().GetRoles();
            ViewBag.roleList = roleList;
            if (!ModelState.IsValid)
            {
                return View("AddEmployee");
            }
            if (Request.Files.Count > 0)
            {
                string fileName = $"{Guid.NewGuid()}{Path.GetFileName(Request.Files[0].FileName)}";
                string extension = Path.GetExtension(Request.Files[0].FileName);
                string filePath = "~/Images/" + fileName + extension;
                Request.Files[0].SaveAs(Server.MapPath(filePath));
                if (extension == "")
                {
                    employee.EmployeeImage = "~/Icons/no-image-icon-4.png";
                }
                else
                {
                    employee.EmployeeImage = filePath;
                }
         
            }
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
            var roleList = new EmployeeListViewModel().GetRoles();
            ViewBag.roleList = roleList;
            var employee = _employeeManager.GetById(id);
            return View("UpdateEmployee", employee);
        }
        [HttpPost]
        public ActionResult UpdateEmployee(Employee employee)
        {
            var departmentList = new DepartmentListViewModel().GetDepartmentsListItems();
            ViewBag.departmentList = departmentList;
            var roleList = new EmployeeListViewModel().GetRoles();
            ViewBag.roleList = roleList;
            if (!ModelState.IsValid)
            {
                return View("UpdateEmployee");
            }
            if (Request.Files.Count > 0)
            {
                string fileName = $"{Guid.NewGuid()}{Path.GetFileName(Request.Files[0].FileName)}";
                string extension = Path.GetExtension(Request.Files[0].FileName);
                string filePath = "~/Images/" + fileName + extension;
                Request.Files[0].SaveAs(Server.MapPath(filePath));
                if (extension == "")
                {
                    employee.EmployeeImage = "~/Icons/no-image-icon-4.png";
                }
                else
                {
                    employee.EmployeeImage = filePath;
                }
           
            }
            _employeeManager.Update(employee);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EmployeeDetailList()
        {
            var model = new EmployeeListViewModel
            {
                Employees = _employeeManager.GetAll()
            };
            return View(model);
        }
    }
}