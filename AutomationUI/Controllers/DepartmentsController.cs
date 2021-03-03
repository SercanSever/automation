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
    public class DepartmentsController : Controller
    {
        IDepartmentManager _departmentManager;
        IEmployeeManager _employeeManager;
        ISalesDetailManager _salesDetailManager;

        public DepartmentsController(IDepartmentManager departmentManager, IEmployeeManager employeeManager, ISalesDetailManager salesDetailManager)
        {
            _departmentManager = departmentManager;
            _employeeManager = employeeManager;
            _salesDetailManager = salesDetailManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new DepartmentListViewModel
            {
                Departments = _departmentManager.GetAll()
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDepartment(Department department)
        {
            _departmentManager.Add(department);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteDepartment(int id)
        {
            var department = _departmentManager.GetById(id);
            department.IsActive = !department.IsActive;
            _departmentManager.Update(department);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateDepartment(int id)
        {
            //var listItems = _departmentManager.GetCategoriesListItems();
            //ViewBag.listItems = _departmentManager;
            var department = _departmentManager.GetById(id);
            return View("UpdateDepartment", department);
        }
        [HttpPost]
        public ActionResult UpdateDepartment(Department department)
        {
            _departmentManager.Update(department);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DepartmentDetail(int id)
        {
            var model = new EmployeeListViewModel
            {
                Employees = _employeeManager.GetDepartmentById(id)
            };
            var departmentName = _departmentManager.GetDepartmentNameById(id);
            ViewBag.departmentName = departmentName;
            return View(model);
        }
        [HttpGet]
        public ActionResult DepartmentEmployeeSales(int id)
        {
            var model = new SalesDetailListViewModel
            {
                SalesDetails = _salesDetailManager.GetSalesByEmployeeId(id)
            };
            var employeeName = _employeeManager.GetEmployeeNameById(id);
            ViewBag.employeeName = employeeName;
            return View(model);
        }
    }
}