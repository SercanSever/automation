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
    public class ProductsController : Controller
    {
        IProductManager _productManager;
        ICategoryManager _categoryManager;
        ISalesDetailManager _salesDetailManager;

        public ProductsController(IProductManager productManager, ICategoryManager categoryManager, ISalesDetailManager salesDetailManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
            _salesDetailManager = salesDetailManager;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                GetProductDetails = _productManager.GetProductDetails()
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            var listItems = new CategoryListViewModel().GetCategoriesListItems();
            ViewBag.listItems = listItems;
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            var listItems = new CategoryListViewModel().GetCategoriesListItems();
            ViewBag.listItems = listItems;
            if (!ModelState.IsValid)
            {
                return View("AddProduct");
            }
            if (Request.Files.Count > 0)
            {
                string fileName = $"{Guid.NewGuid()}{Path.GetFileName(Request.Files[0].FileName)}";
                string extension = Path.GetExtension(Request.Files[0].FileName);
                string filePath = "~/Images/" + fileName + extension;
                Request.Files[0].SaveAs(Server.MapPath(filePath));
                if (extension == "")
                {
                    product.ProductImage = "~/Icons/no-image-icon-4.png";
                }
                else
                {
                    product.ProductImage = filePath;
                }
            }
           
            _productManager.Add(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteProduct(int id)
        {
            var product = _productManager.GetById(id);
            product.IsActive = !product.IsActive;
            _productManager.Update(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var product = _productManager.GetById(id);
            if (Request.Files.Count > 0)
            {
                string fileName = $"{Guid.NewGuid()}{Path.GetFileName(Request.Files[0].FileName)}";
                string extension = Path.GetExtension(Request.Files[0].FileName);
                string filePath = "~/Images/" + fileName + extension;
                Request.Files[0].SaveAs(Server.MapPath(filePath));
                product.ProductImage = filePath;
            }
            var listItems = new CategoryListViewModel().GetCategoriesListItems();
            ViewBag.listItems = listItems;

            return View("UpdateProduct", product);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            var listItems = new CategoryListViewModel().GetCategoriesListItems();
            ViewBag.listItems = listItems;
            if (!ModelState.IsValid)
            {
                return View("UpdateProduct");
            }
            _productManager.Update(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult WriteProductListToPdf()
        {
            var model = new ProductListViewModel
            {
                Products = _productManager.GetAll()
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult Sell(int id)
        {
            var customerListItems = new CustomerListViewModel().GetCustomerListItems();
            ViewBag.customerListItems = customerListItems;
            var employeeListItems = new EmployeeListViewModel().GetEmployeeListItems();
            ViewBag.employeeListItems = employeeListItems;
            var product = _productManager.GetById(id);
            ViewBag.productId = product.ProductId;
            ViewBag.productName = product.ProductName;
            ViewBag.productPrice = product.UnitPrice;
            return View();
        }
        [HttpPost]
        public ActionResult Sell(SalesDetail salesDetail)
        {
            salesDetail.SalesDetailDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            _salesDetailManager.Add(salesDetail);
            return RedirectToAction("Index", "SalesDetails");
        }
    }
}