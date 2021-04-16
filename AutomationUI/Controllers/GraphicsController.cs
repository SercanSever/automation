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
        ISalesDetailManager _salesDetailManager;

        public GraphicsController(ISalesDetailManager salesDetailManager)
        {
            _salesDetailManager = salesDetailManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}