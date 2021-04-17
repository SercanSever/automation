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

    public class BoardsController : Controller
    {

        ICustomerManager _customerManager;
        IProductManager _productManager;
        ISalesDetailManager _salesDetailManager;
        IExpenseManager _expenseManager;
        public BoardsController(ICustomerManager customerManager, IProductManager productManager, ISalesDetailManager salesDetailManager, IExpenseManager expenseManager)
        {

            _customerManager = customerManager;
            _productManager = productManager;
            _salesDetailManager = salesDetailManager;
            _expenseManager = expenseManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.adminName = Session["AdminName"];
            var customermodel = new CustomerListViewModel
            {
                Customers = _customerManager.GetAllActives()
            };
            ViewBag.customers = customermodel.Customers.Count().ToString();
            ViewBag.customerCount = customermodel.Customers.Where(x => x.IsActive == true).OrderByDescending(x => x.DateOfRegister).Take(10).Count();
            var productModel = new ProductListViewModel
            {
                Products = _productManager.GetAll()
            };
            ViewBag.products = productModel.Products.Count().ToString();
            var salesModel = new SalesDetailListViewModel
            {
                SalesDetails = _salesDetailManager.GetAll()
            };
            ViewBag.sales = salesModel.SalesDetails.Sum(x => x.SalesDetailTotal).ToString();
            var expenseModel = new ExpenseListViewModel
            {
                Expenses = _expenseManager.GetAll()
            };
            ViewBag.expenseTotal = expenseModel.Expenses.Sum(x => x.ExpenseTotal).ToString();
            var customerLisst = _customerManager.GetAll().Take(10).ToList();
            var salesList = _salesDetailManager.GetAll().OrderByDescending(x => x.SalesDetailDate).Take(10).ToList();
            var productList = _productManager.GetAll().Where(x => x.IsActive == true).OrderByDescending(x => x.ProductId).Take(5).ToList();
            return View(Tuple.Create<List<Customer>, List<SalesDetail>, List<Product>>(customerLisst, salesList, productList));
        }

    }
}