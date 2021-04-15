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
        IExpenseManager _expenseManager;
        public BoardsController(ICustomerManager customerManager, IProductManager productManager, ISalesDetailManager salesDetailManager,IExpenseManager expenseManager)
        {

            _customerManager = customerManager;
            _productManager = productManager;
            _salesDetailManager = salesDetailManager;
            _expenseManager = expenseManager;
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
            ViewBag.sales = salesModel.SalesDetails.Sum(x=>x.SalesDetailTotal).ToString();
            var expenseModel = new ExpenseListViewModel
            {
                Expenses = _expenseManager.GetAll()
            };
            ViewBag.expenseTotal = expenseModel.Expenses.Sum(x=>x.ExpenseTotal).ToString();
            return View();
        }
    }
}