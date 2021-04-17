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
    public class CustomersController : Controller
    {
        ICustomerManager _customerManager;
        ISalesDetailManager _salesDetailManager;

        public CustomersController(ICustomerManager customerManager, ISalesDetailManager salesDetailManager)
        {
            _customerManager = customerManager;
            _salesDetailManager = salesDetailManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new CustomerListViewModel
            {
                Customers = _customerManager.GetAll()
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            customer.DateOfRegister = DateTime.Now;
            _customerManager.Add(customer);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteCustomer(int id)
        {
            var customer = _customerManager.GetById(id);
            customer.IsActive = !customer.IsActive;
            _customerManager.Update(customer);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCustomer(int id)
        {
            var customer = _customerManager.GetById(id);
            return View("UpdateCustomer", customer);
        }
        [HttpPost]
        public ActionResult UpdateCustomer(Customer customer)
        {
            customer.DateOfRegister = DateTime.Now;
            _customerManager.Update(customer);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CustomerDetails(int id)
        {
            var model = new SalesDetailListViewModel
            {
                SalesDetails = _salesDetailManager.GetSalesByCustomerId(id)
            };
            return View(model);
        }
    }
}