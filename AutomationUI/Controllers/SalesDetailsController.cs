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
    public class SalesDetailsController : Controller
    {
        ISalesDetailManager _salesDetailManager;

        public SalesDetailsController(ISalesDetailManager salesDetailManager)
        {
            _salesDetailManager = salesDetailManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new SalesDetailListViewModel
            {
                SalesDetails = _salesDetailManager.GetAll().OrderByDescending(x => x.SalesDetailId).ToList()
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult AddSalesDetail()
        {
            var brandListItems = new ProductListViewModel().GetBrandListItems();
            ViewBag.brandListItems = brandListItems;
            var productListItems = new ProductListViewModel().GetProductNameListItems();
            ViewBag.productListItems = productListItems;
            var customerListItems = new CustomerListViewModel().GetCustomerListItems();
            ViewBag.customerListItems = customerListItems;
            var employeeListItems = new EmployeeListViewModel().GetEmployeeListItems();
            ViewBag.employeeListItems = employeeListItems;
            return View();
        }
        [HttpPost]
        public ActionResult AddSalesDetail(SalesDetail salesDetail)
        {
            _salesDetailManager.Add(salesDetail);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteSalesDetail(int id)
        {
            var salesDetail = _salesDetailManager.GetById(id);
            _salesDetailManager.Update(salesDetail);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSalesDetail(int id)
        {
            //var productListItems = new ProductListViewModel().GetProductNameListItems();
            //ViewBag.productListItems = productListItems;
            //var brandListItems = new ProductListViewModel().GetBrandListItems();
            //ViewBag.brandListItems = brandListItems;
            var customerListItems = new CustomerListViewModel().GetCustomerListItems();
            ViewBag.customerListItems = customerListItems;
            var employeeListItems = new EmployeeListViewModel().GetEmployeeListItems();
            ViewBag.employeeListItems = employeeListItems;
            var salesDetail = _salesDetailManager.GetById(id);
            return View("UpdateSalesDetail", salesDetail);
        }
        [HttpPost]
        public ActionResult UpdateSalesDetail(SalesDetail salesDetail)
        {
            _salesDetailManager.Update(salesDetail);
            return RedirectToAction("Index");
        }
    }
}