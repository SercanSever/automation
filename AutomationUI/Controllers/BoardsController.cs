using Automation.Business.Abstract;
using AutomationUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomationUI.Controllers
{
    public class BoardsController : Controller
    {
  
        ICustomerManager _customerManager;
        IProductManager _productManager;
        ISalesDetailManager _salesDetailManager;
        public BoardsController(ICustomerManager customerManager, IProductManager productManager, ISalesDetailManager salesDetailManager)
        {

            _customerManager = customerManager;
            _productManager = productManager;
            _salesDetailManager = salesDetailManager;
        }

        [HttpGet]
        public ActionResult Index()
        {

            var customermodel = new CustomerListViewModel
            {
                Customers = _customerManager.GetAll()
            };
            ViewBag.customers = customermodel.Customers.Count().ToString();
            var productModel = new ProductListViewModel
            {
                Products = _productManager.GetAll()
            };
            ViewBag.products = productModel.Products.Count().ToString();
            var salesModel = new SalesDetailListViewModel
            {
                SalesDetails = _salesDetailManager.GetAll()
            };
            ViewBag.sales = salesModel.SalesDetails.Count().ToString();

            return View();
        }
    }
}