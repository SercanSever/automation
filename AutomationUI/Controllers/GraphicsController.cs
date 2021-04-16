using Automation.Business.Abstract;
using AutomationUI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace AutomationUI.Controllers
{
    public class GraphicsController : Controller
    {
        IProductManager _productManager;
        ISalesDetailManager _salesDetailManager;

        public GraphicsController(IProductManager productManager, ISalesDetailManager salesDetailManager)
        {
            _productManager = productManager;
            _salesDetailManager = salesDetailManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var salesDetailList = new SalesDetailListViewModel
            {
                SalesDetails = _salesDetailManager.GetAll()
            };
            return View(salesDetailList);
        }
        [HttpGet]
        public ActionResult deneme()
        {
            return View();
        }
    }
}