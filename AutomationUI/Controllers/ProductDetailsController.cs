using Automation.Business.Abstract;
using AutomationUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomationUI.Controllers
{
    public class ProductDetailsController : Controller
    {
        IProductManager _productManager;

        public ProductDetailsController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        [HttpGet]
        public ActionResult Index(int id)
        {
            //var model = new ProductListViewModel
            //{
            //    GetProductDetailsById = _productManager.GetProductDetailsById(id)
            //};
            var model = _productManager.GetById(id);
            return View(model);
        }
    }
}